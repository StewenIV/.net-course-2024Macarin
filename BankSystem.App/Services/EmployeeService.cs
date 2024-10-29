using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using BankSystem.Appl.Exceptions;
using BankSystem.Appl.Interfaces;
using BankSystem.Dom.Models;

namespace BankSystem.App.Services;

public class EmployeeService
{
    private readonly IEmployeeStorage _employeeStorage;

    public EmployeeService(IEmployeeStorage employeeStorage)
    {
        _employeeStorage = employeeStorage;
    }
    
    public bool IsEmployeeExist(Guid employeeId)
    {
        if(employeeId == Guid.Empty)
            throw new ArgumentNullException(nameof(employeeId));
        return _employeeStorage.IsEmployeeExist(employeeId);
    }
    
    public Employee GetEmployeeById(Guid employeeId)
    {
        if(employeeId == Guid.Empty)
            throw new ArgumentNullException(nameof(employeeId));
        return _employeeStorage.GetById(employeeId);
    }

    public Task<Employee> GetEmployeeByIdAsync(Guid employeeId)
    {
        if(employeeId == Guid.Empty)
            throw new ArgumentNullException(nameof(employeeId));
        return _employeeStorage.GetByIdAsync(employeeId);
    }
    
    public void AddEmployee(Employee employee)
    {
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(employee);
        bool isValid = Validator.TryValidateObject(employee, validationContext, validationResults, true);
        if (!isValid)
        {
            var errorMessage = string.Join("; ", validationResults.Select(vr => vr.ErrorMessage));
            throw new ValidationException($"Client is not valid: {errorMessage}");
        }

        if (employee.Age < 18)
            throw new InvalidPersonAgeException("Client is under 18");
        if (employee.PassportDetails is null)
            throw new PassportDetailsNullException(nameof(employee.PassportDetails));

        _employeeStorage.Add(employee);
    }
    
    public async Task AddEmployeeAsync(Employee employee)
    {
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(employee);
        bool isValid = Validator.TryValidateObject(employee, validationContext, validationResults, true);
        if (!isValid)
        {
            var errorMessage = string.Join("; ", validationResults.Select(vr => vr.ErrorMessage));
            throw new ValidationException($"Client is not valid: {errorMessage}");
        }

        if (employee.Age < 18)
            throw new InvalidPersonAgeException("Client is under 18");
        if (employee.PassportDetails is null)
            throw new PassportDetailsNullException(nameof(employee.PassportDetails));

        await _employeeStorage.AddAsync(employee);
    }

    public List<Employee> GetEmployees(Expression<Func<Employee, bool>> filter,
        Func<IQueryable<Employee>, IOrderedQueryable<Employee>> orderBy, int page, int pageSize)
    {
        if (filter is null)
            throw new ArgumentNullException(nameof(filter));
        return _employeeStorage.Get(filter, orderBy, page, pageSize);
    }
    
    public Task<List<Employee>> GetEmployeesAsync(Expression<Func<Employee, bool>> filter,
        Func<IQueryable<Employee>, IOrderedQueryable<Employee>> orderBy, int page, int pageSize)
    {
        if (filter is null)
            throw new ArgumentNullException(nameof(filter));
        return _employeeStorage.GetAsync(filter, orderBy, page, pageSize);
    }

    public void UpdateEmployee(Employee oldEmployee, Employee newEmployee)
    {
        if (oldEmployee is null)
            throw new ArgumentNullException(nameof(oldEmployee));
        if (newEmployee is null)
            throw new ArgumentNullException(nameof(newEmployee));
        var byId = _employeeStorage.GetById(oldEmployee.Id);
        if (byId is null)
            throw new ArgumentException("Employee not found");
        _employeeStorage.Update(oldEmployee.Id, newEmployee);
    }
    
    public async Task UpdateEmployeeAsync(Employee oldEmployee, Employee newEmployee)
    {
        if (oldEmployee is null)
            throw new ArgumentNullException(nameof(oldEmployee));
        if (newEmployee is null)
            throw new ArgumentNullException(nameof(newEmployee));
        var byId = await _employeeStorage.GetByIdAsync(oldEmployee.Id);
        if (byId is null)
            throw new ArgumentException("Employee not found");
        await _employeeStorage.UpdateAsync(oldEmployee.Id, newEmployee);
    }
    
    public void RemoveEmployee(Employee employee)
    {
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        _employeeStorage.Delete(employee.Id);
    }
    
    public async Task RemoveEmployeeAsync(Employee employee)
    {
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        await _employeeStorage.DeleteAsync(employee.Id);
    }
}