using System.Linq.Expressions;
using BankSystem.App.Services;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;

namespace BankSystem.Data.Test;

public class StorageEmployeeTests
{
    [Fact]
    public void AddEmployee_ShouldAddEmployee_WhenEmployeeIsValid()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeePasha = TestDataGenerator.GenerateEmployees(1).First();

        //Act 
        storage.Add(employeePasha);

        //Assert
        Assert.NotNull(storage.GetById(employeePasha.Id));
    }

    [Fact]
    public void AddEmployee_ShouldTrowArgumentNullException_WhenEmployeeIsNull()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        Employee employeePasha = null;

        //Act
        var exception = Record.Exception(() => storage.Add(employeePasha));

        //Assert
        Assert.True(exception is ArgumentNullException);
    }

    [Fact]
    public void AddEmployee_ShouldTrowArgumentException_WhenEmployeeAlreadyExists()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employee = context.Employees.First();

        //Act
        var exception = Record.Exception(() => storage.Add(employee));

        //Act and Assert
        Assert.True(exception is ArgumentException);
    }
    
    [Fact]
    public void RemoveEmployee_ShouldRemoveEmployee_WhenEmployeeExists()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employee = context.Employees.First();

        //Act
        storage.Delete(employee.Id);

        //Assert
        Assert.Null(storage.GetById(employee.Id));
    }

    [Fact]
    public void RemoveEmployee_ShouldThrowArgumentNullException_WhenEmployeeIsNull()
    {
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        Employee employeePasha = null;

        //Act
        var exception = Record.Exception(() => storage.Delete(employeePasha.Id));

        //Assert
        Assert.True(exception is ArgumentException);
    }

    [Fact]
    public void RemoveEmployee_ShouldThrowArgumentException_WhenEmployeeNotFound()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeSasha = new Employee
        {
            Name = "Sasha",
            Surname = "Macarin",
            Email = "copyemail@mgamil.com",
            PhoneNumber = "123456789",
            BirthDate = new DateTime(1990, 1, 1),
            Address = "Bender",
            Position = "Developer",
            Salary = 1000m,
            EndDate = DateTime.Now.AddYears(1)
        };

        //Act
        var exception = Record.Exception(() => storage.Delete(employeeSasha.Id));

        //Assert
        Assert.True(exception is ArgumentException);
    }
}