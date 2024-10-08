using System.ComponentModel.DataAnnotations;
using BankSystem.Appl.Exceptions;
using BankSystem.Appl.Interfaces;
using BankSystem.Dom.Models;

namespace BankSystem.App.Services;

public class EmployeeService
{
    private readonly IEmployeeStorage _iStorage;

    public EmployeeService(IEmployeeStorage iStorage)
    {
        _iStorage = iStorage;
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

        _iStorage.Add(employee);
    }
    
    public List<Employee> GetEmployees(string name = null, string surname = null,
        string phoneNumber = null,
        string passportDetails = null, DateTime start = default, DateTime end = default)
    {
        if (end == default)
            end = DateTime.Now;
        var clients = _iStorage.Get(c => (name == null || c.Name == name) &&
                                                            (surname == null || c.Surname == surname) &&
                                                            (phoneNumber == null || c.PhoneNumber == phoneNumber) &&
                                                            (passportDetails == null ||
                                                             c.PassportDetails == passportDetails) &&
                                                            ((start == default || c.BirthDate >= start) &&
                                                             (end != default || c.BirthDate <= end)))
            .ToList();
        return clients;
    }
    
    public void UpdateEmployee(Employee oldEmployee, Employee newEmployee)
    {
        if (oldEmployee is null)
            throw new ArgumentNullException(nameof(oldEmployee));
        if (newEmployee is null)
            throw new ArgumentNullException(nameof(newEmployee));
        if (!_iStorage.Get(c => Equals(c, oldEmployee)).Any())
            throw new ArgumentException("Employee not found");
        _iStorage.Update(oldEmployee, newEmployee);
    }
    
    public void RemoveEmployee(Employee employee)
    {
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        _iStorage.Delete(employee);
    }
}