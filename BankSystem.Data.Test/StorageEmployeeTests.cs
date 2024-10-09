using System.Linq.Expressions;
using BankSystem.App.Services;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;

namespace BankSystem.Data.Test;

public class StorageEmployeeTests
{
    [Fact]
    public void AddEmployee_ShouldAddEmployee_WhenEmployeeIsValid()
    {
        //Arrange
        var employees = new List<Employee>();
        var storage = new EmployeeStorage(employees);
        var employeePasha = new Employee
        {
            Name = "Pasha",
            Surname = "Ivanov",
            Email = "aslda@gmail.com",
            PhoneNumber = "123456789",
            Age = 25,
            Address = "Tiraspol",
            Position = "Developer",
            Salary = 1000m,
            Currency = new Currency { Name = "Dollar", Code = CurrencyCode.Usd },
            EndDate = DateTime.Now.AddYears(1)
        };

        //Act 
        storage.Add(employeePasha);

        //Assert
        Assert.NotEmpty(storage.Get(c => Equals(c, employeePasha)));
    }

    [Fact]
    public void AddEmployee_ShouldTrowArgumentNullException_WhenEmployeeIsNull()
    {
        //Arrange
        var employees = new List<Employee>();
        var storage = new EmployeeStorage(employees);
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
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employee = employees.First();

        //Act
        var exception = Record.Exception(() => storage.Add(employee));

        //Act and Assert
        Assert.True(exception is ArgumentException);
    }
    
    [Fact]
    public void RemoveEmployee_ShouldRemoveEmployee_WhenEmployeeExists()
    {
        //Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employee = employees.First();

        //Act
        storage.Delete(employee);

        //Assert
        Assert.Empty( storage.Get(c => Equals(c, employee)));
    }

    [Fact]
    public void RemoveEmployee_ShouldThrowArgumentNullException_WhenEmployeeIsNull()
    {
        //Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        Employee employeePasha = null;

        //Act
        var exception = Record.Exception(() => storage.Delete(employeePasha));

        //Assert
        Assert.True(exception is ArgumentNullException);
    }

    [Fact]
    public void RemoveEmployee_ShouldThrowArgumentException_WhenEmployeeNotFound()
    {
        //Arrange
        var employeeSasha = new Employee
        {
            Name = "Sasha",
            Surname = "Macarin",
            Email = "copyemail@mgamil.com",
            PhoneNumber = "123456789",
            Age = 19,
            Address = "Bender",
            Position = "Developer",
            Salary = 1000m,
            Currency = new Currency { Name = "Dollar", Code = CurrencyCode.Usd },
            EndDate = DateTime.Now.AddYears(1)
        };
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);

        //Act
        var exception = Record.Exception(() => storage.Delete(employeeSasha));

        //Assert
        Assert.True(exception is ArgumentException);
    }
}