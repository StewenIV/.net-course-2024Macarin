using System.Linq.Expressions;
using BankSystem.Appl.Interfaces;
using BankSystem.Data.DbContext;
using BankSystem.Dom.Models;

namespace BankSystem.Data.Storages;

public class EmployeeStorage : IEmployeeStorage
{
    private readonly BankSystemDbContext _context;

    public EmployeeStorage(BankSystemDbContext context)
    {
        _context = context;
    }

    public Employee GetById(Guid employeeId)
    {
        var employee = _context.Employees
            .FirstOrDefault(c => c.Id == employeeId);
        if (employee is null)
            throw new ArgumentException("Employee not found");
        return employee;
    }

    public void Add(Employee employee)
    {
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        var employeesExist = _context.Employees.Any(c => c.Email == employee.Email);
        if (employeesExist)
            throw new ArgumentException("Employee already exists");
        _context.Add(employee);
        _context.SaveChanges();
    }

    public void Update(Guid oldEmployeeId, Employee newEmployee)
    {
        if (newEmployee is null)
            throw new ArgumentNullException(nameof(newEmployee));
        var employee = GetById(oldEmployeeId);
        if (employee is null)
            throw new ArgumentException("Employee not found");
        employee.Name = newEmployee.Name;
        employee.Surname = newEmployee.Surname;
        employee.PhoneNumber = newEmployee.PhoneNumber;
        employee.Email = newEmployee.Email;
        employee.Address = newEmployee.Address;
        employee.PassportDetails = newEmployee.PassportDetails;
        employee.BirthDate = newEmployee.BirthDate;
        employee.Bonus = newEmployee.Bonus;
        employee.Position = newEmployee.Position;
        employee.StartDate = newEmployee.StartDate;
        employee.EndDate = newEmployee.EndDate;
        employee.Salary = newEmployee.Salary;
        _context.SaveChanges();
    }

    public List<Employee> Get(Expression<Func<Employee, bool>> filter,
        Func<IQueryable<Employee>, IOrderedQueryable<Employee>> orderBy, int page, int pageSize)
    {
        IQueryable<Employee> employeesQuery = _context.Employees;
        if (filter is not null)
            employeesQuery = employeesQuery.Where(filter);

        employeesQuery = orderBy != null ? orderBy(employeesQuery) : employeesQuery.OrderBy(c => c.Id);
        page = page < 1 ? 1 : page;
        pageSize = pageSize < 1 ? 1 : pageSize;

        var pagedEmployees = employeesQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return pagedEmployees;
    }

    public void Delete(Guid employeeId)
    {
        if (employeeId == Guid.Empty)
            throw new ArgumentNullException(nameof(employeeId));
        var employee = GetById(employeeId);
        if (employee is null)
            throw new ArgumentException("Employee not found");
        _context.Employees.Remove(employee);
        _context.SaveChanges();
    }
    
    public bool IsEmployeeExist(Guid employeeId)
    {
        return _context.Employees.Any(c => c.Id == employeeId);
    }
 }