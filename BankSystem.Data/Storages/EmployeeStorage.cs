using BankSystem.Appl.Interfaces;
using BankSystem.Dom.Models;

namespace BankSystem.Data.Storages;

public class EmployeeStorage : IEmployeeStorage
{
    private readonly List<Employee> _employees;

    public EmployeeStorage(List<Employee> employees)
    {
        _employees = employees;
    }

    public void Add(Employee employee)
    {
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        if (_employees.Exists(c => c.Equals(employee)))
            throw new ArgumentException("Employee already exists");
        _employees.Add(employee);
    }

    public void Update(Employee oldEmployee, Employee newEmployee)
    {
        if (oldEmployee is null)
            throw new ArgumentNullException(nameof(oldEmployee));
        if (newEmployee is null)
            throw new ArgumentNullException(nameof(newEmployee));
        if (!_employees.Contains(oldEmployee))
            throw new ArgumentException("Employee not found");
        var index = _employees.IndexOf(oldEmployee);
        _employees[index] = newEmployee;
    }

    public List<Employee> Get(Func<Employee, bool> filter)
    {
        if (filter is null)
            throw new ArgumentNullException(nameof(filter));
        return _employees.Where(filter).ToList();
    }

    public void Delete(Employee employee)
    {
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        if (0 > _employees.IndexOf(employee))
            throw new ArgumentException("Employee not found");
        _employees.Remove(employee);
    }
}