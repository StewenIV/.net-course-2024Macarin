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
        storage.AddEmployee(employeePasha);

        //Assert
        Assert.Contains(employeePasha, storage.Employees);
    }

    [Fact]
    public void AddEmployee_ShouldTrowArgumentNullException_WhenEmployeeIsNull()
    {
        //Arrange
        var employees = new List<Employee>();
        var storage = new EmployeeStorage(employees);
        Employee employeePasha = null;

        //Act
        var exception = Record.Exception(() => storage.AddEmployee(employeePasha));

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
        var exception = Record.Exception(() => storage.AddEmployee(employee));

        //Act and Assert
        Assert.True(exception is ArgumentException);
    }

    [Fact]
    public void GetYoungestEmployee_ShouldReturnYoungestEmployee_WhenEmployeesExist()
    {
        //Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);

        //Act
        var youngestEmployee = storage.GetYoungestEmployee();

        //Assert
        Assert.Equal(employees.Min(c => c.Age), youngestEmployee.Age);
    }

    [Fact]
    public void GetYoungestEmployee_ShouldThrowInvalidOperationException_WhenNoEmployeesExist()
    {
        //Arrange
        var storage = new EmployeeStorage(new List<Employee>());

        //Act
        var exception = Record.Exception(() => storage.GetYoungestEmployee());

        //Assert
        Assert.True(exception is InvalidOperationException);
    }

    [Fact]
    public void GetOldestEmployee_ShouldReturnOldestEmployee_WhenEmployeesExist()
    {
        //Arrange
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
        var employeeSasha = new Employee
        {
            Name = "Sasha",
            Surname = "Macarin",
            Email = "copyemail@mgamil.com",
            PhoneNumber = "123456789",
            Age = 20,
            Address = "Bender",
            Position = "Developer",
            Salary = 1000m,
            Currency = new Currency { Name = "Dollar", Code = CurrencyCode.Usd },
            EndDate = DateTime.Now.AddYears(1)
        };
        var employees = new List<Employee> { employeePasha, employeeSasha };
        var storage = new EmployeeStorage(employees);

        //Act
        var oldestEmployee = storage.GetOldestEmployee();

        //Assert
        Assert.Equal(employees.Max(c => c.Age), oldestEmployee.Age);
    }

    [Fact]
    public void GetOldestEmployee_ShouldTrowInvalidOperationException_WhenNoEmployeesExist()
    {
        var storage = new EmployeeStorage(new List<Employee>());

        //Act
        var exception = Record.Exception(() => storage.GetOldestEmployee());

        //Assert
        Assert.True(exception is InvalidOperationException);
    }

    [Fact]
    public void GetAverageAge_ShouldReturnAverageAge_WhenEmployeesExist()
    {
        //Arrange
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
        var employees = new List<Employee> { employeePasha, employeeSasha };
        var storage = new EmployeeStorage(employees);

        //Act
        var averageAge = storage.GetAverageAge();

        //Assert
        Assert.Equal((employeePasha.Age + employeeSasha.Age) / 2, averageAge);
    }

    [Fact]
    public void GetAverageAde_ShouldTrowInvalidOperationException_WhenNoEmployeesExist()
    {
        //Arrange
        var storage = new EmployeeStorage(new List<Employee>());

        //Act
        var exception = Record.Exception(() => storage.GetAverageAge());

        //Assert
        Assert.True(exception is InvalidOperationException);
    }

    [Fact]
    public void RemoveEmployee_ShouldRemoveEmployee_WhenEmployeeExists()
    {
        //Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employee = employees.First();

        //Act
        storage.RemoveEmployee(employee);

        //Assert
        Assert.DoesNotContain(employee, storage.Employees);
    }

    [Fact]
    public void RemoveEmployee_ShouldThrowArgumentNullException_WhenEmployeeIsNull()
    {
        //Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        Employee employeePasha = null;

        //Act
        var exception = Record.Exception(() => storage.RemoveEmployee(employeePasha));

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
        var exception = Record.Exception(() => storage.RemoveEmployee(employeeSasha));

        //Assert
        Assert.True(exception is ArgumentException);
    }
}