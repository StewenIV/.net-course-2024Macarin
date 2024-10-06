using System.ComponentModel.DataAnnotations;
using BankSystem.Appl.Exceptions;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;

namespace BankSystem.App.Services;

public class EmployeeService
{
    private readonly EmployeeStorage _employeeStorage;

    public EmployeeService(EmployeeStorage employeeStorage)
    {
        _employeeStorage = employeeStorage;
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

        _employeeStorage.AddEmployee(employee);
    }

    public Employee GetYoungestEmployee(Employee employee)
    {
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        if (!_employeeStorage.Employees.Contains(employee))
            throw new ArgumentException("Client not found");

        return _employeeStorage.GetYoungestEmployee();
    }

    public List<Employee> GetEmployees(string name = null, string surname = null,
        string phoneNumber = null,
        string passportDetails = null, DateTime start = default, DateTime end = default)
    {
        if (end == default)
            end = DateTime.Now;
        var clients = _employeeStorage.Employees.Where(c => (name == null || c.Name == name) &&
                                                            (surname == null || c.Surname == surname) &&
                                                            (phoneNumber == null || c.PhoneNumber == phoneNumber) &&
                                                            (passportDetails == null ||
                                                             c.PassportDetails == passportDetails) &&
                                                            ((start == default || c.BirthDate >= start) &&
                                                             (end != default || c.BirthDate <= end)))
            .ToList();
        return clients;
    }
}