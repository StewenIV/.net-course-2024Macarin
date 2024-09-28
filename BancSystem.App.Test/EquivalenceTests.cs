using BankSystem.App.Services;
using BankSystem.Dom.Models;

namespace BancSystem.App.Test;

public class EquivalenceTests
{
    [Fact] public void GenerateDictionary_ClientWithSameProperties_FoundInDictionary()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var clientAccount = TestDataGenerator.GenerateDictionary(clients);
        var firstClient = clients.First();
        var newClient = new Client
        {
            Name = firstClient.Name,
            Surname = firstClient.Surname,
            PhoneNumber = firstClient.PhoneNumber,
            Email = firstClient.Email,
            Age = firstClient.Age,
            Address = firstClient.Address,
            OrderNumber = firstClient.OrderNumber,
            OrderAmount = firstClient.OrderAmount
        };

        // Act
        var foundAccount = clientAccount.TryGetValue(newClient, out var accounts);

        // Assert
        Assert.True(foundAccount);
    }

    [Fact]
    public void GenerateDictionary_ClientWithSameProperties_NotFoundInDictionary()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var clientAccount = TestDataGenerator.GenerateDictionary(clients);
        var firstClient = clients.First();
        var newClient = new Client
        {
            Name = firstClient.Name,
            Surname = firstClient.Surname,
            PhoneNumber = firstClient.PhoneNumber,
            Email = firstClient.Email,
            Age = firstClient.Age,
            Address = firstClient.Address,
            OrderNumber = firstClient.OrderNumber,
            OrderAmount = firstClient.OrderAmount
        };

        // Act
        var foundAccount = clientAccount.TryGetValue(newClient, out var accounts);

        // Assert
        Assert.False(foundAccount);
    }

    [Fact]
    public void GenerateEmployees_EmployeeWithSameProperties_FoundInList()
    {
        // Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var firstEmployee = employees.First();
        var newEmployee = new Employee()
        {
            Name = firstEmployee.Name,
            Surname = firstEmployee.Surname,
            PhoneNumber = firstEmployee.PhoneNumber,
            Email = firstEmployee.Email,
            Age = firstEmployee.Age,
            Address = firstEmployee.Address,
            Position = firstEmployee.Position,
            StartDate = firstEmployee.StartDate,
            EndDate = firstEmployee.EndDate,
            Salary = firstEmployee.Salary,
            Currency = firstEmployee.Currency,
            Contract = firstEmployee.Contract
        };

        // Act
        var foundClient = employees.Contains(newEmployee);

        // Assert
        Assert.True(foundClient);
    }

    [Fact]
    public void GenerateEmployees_EmployeeWithSameProperties_NotFoundInList()
    {
        // Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var firstEmployee = employees.First();
        var newEmployee = new Employee()
        {
            Name = firstEmployee.Name,
            Surname = firstEmployee.Surname,
            PhoneNumber = firstEmployee.PhoneNumber,
            Email = firstEmployee.Email,
            Age = firstEmployee.Age,
            Address = firstEmployee.Address,
            Position = firstEmployee.Position,
            StartDate = firstEmployee.StartDate,
            EndDate = firstEmployee.EndDate,
            Salary = firstEmployee.Salary,
            Currency = firstEmployee.Currency,
            Contract = firstEmployee.Contract
        };

        // Act
        var foundClient = employees.Contains(newEmployee);

        // Assert
        Assert.False(foundClient);
    }
}