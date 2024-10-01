using BankSystem.Data.Primitivies;
using BankSystem.Dom.Models;

namespace BankSystem.Data.Storages;

public class EmployeeStorage
{
    private readonly List<Employee> _employees;

    public EmployeeStorage(List<Employee> employees)
    {
        _employees = employees;
    }

    public List<Employee> Employees => _employees;

    public void AddEmployee(Employee employee)
    {
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        if (_employees.Exists(c => c.Equals(employee)))
            throw new ArgumentException("Employee already exists");
        if (!employee.AreAllPropertiesSet())
            throw new InvalidOperationException("Employee properties are not fully set");
        _employees.Add(employee);
    }

    public Employee GetYoungestEmployee()
    {
        if (!_employees.Any())
            throw new InvalidOperationException("No employees in storage");
        return _employees.Aggregate((youngest, next) => next.Age < youngest.Age ? next : youngest);
    }

    public Employee GetOldestEmployee()
    {
        if (!_employees.Any())
            throw new InvalidOperationException("No employees in storage");
        return _employees.Aggregate((oldest, next) => oldest.Age < next.Age ? next : oldest);
    }

    public int GetAverageAge()
    {
        if (!_employees.Any())
            throw new InvalidOperationException("No employees in storage");
        return (int)_employees.Average(c => c.Age);
    }

    public void RemoveEmployee(Employee employee)
    {
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        if (0 > _employees.IndexOf(employee))
            throw new ArgumentException("Employee not found");
        _employees.Remove(employee);
    }
}