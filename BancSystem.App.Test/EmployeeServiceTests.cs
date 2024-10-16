using System.ComponentModel.DataAnnotations;
using BankSystem.App.Services;
using BankSystem.Appl.Exceptions;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;

namespace BancSystem.App.Test;

public class EmployeeServiceTests
{
    [Fact]
    public void AddEmployee_WhenEmployeeIsValid_ShouldAddEmployee()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        context.Employees.AddRangeAsync(TestDataGenerator.GenerateEmployees(10));
        context.SaveChanges();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employeeSasha = new Employee
        {
            Name = "Sasha",
            Surname = "Macarin",
            Email = "copyemail@mgamil.com",
            PhoneNumber = "123456789",
            BirthDate = new DateTime(2004, 1, 1),
            Address = "Bender",
            Position = "Developer",
            Salary = 1000m,
            PassportDetails = "Passport Details",
            EndDate = DateTime.Now.AddYears(1)
        };

        //Act
        employeeService.AddEmployee(employeeSasha);

        //Assert
        Assert.NotNull(employeeService.GetEmployeeById(employeeSasha.Id));
    }

    [Fact]
    public void AddEmployee_WhenEmployeeIsUnder18_ShouldThrowInvalidPersonAgeException()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        context.Employees.AddRangeAsync(TestDataGenerator.GenerateEmployees(10));
        context.SaveChanges();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
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
            PassportDetails = "Passport Details",
            EndDate = DateTime.Now.AddYears(1)
        };

        //Act
        try
        {
            employeeService.AddEmployee(employeeSasha);
        }
        catch (InvalidPersonAgeException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void AddEmployee_WhenEmployeePassportDetailsIsNull_ShouldThrowPassportDetailsNullException()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        context.Employees.AddRangeAsync(TestDataGenerator.GenerateEmployees(10));
        context.SaveChanges();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
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
            PassportDetails = null,
            EndDate = DateTime.Now.AddYears(1)
        };

        //Act
        try
        {
            employeeService.AddEmployee(employeeSasha);
        }
        catch (PassportDetailsNullException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void AddEmployee_WhenEmployeeIsNotValid_ShouldThrowValidationException()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        context.Employees.AddRangeAsync(TestDataGenerator.GenerateEmployees(10));
        context.SaveChanges();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employeeSasha = new Employee
        {
            Name = "Sasha",
            Surname = "Macarin",
            Email = ""
        };

        //Act
        try
        {
            employeeService.AddEmployee(employeeSasha);
        }
        catch (ValidationException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void GetEmployee_WhenEmployeeNameIsDefined_ShouldReturnEmployeeByName()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employee = context.Employees.First();

        //Act
        var employees = employeeService.GetEmployees(c => c.Name == employee.Name, c => c.OrderBy(e => e.Id), 1, 10);

        //Assert
        Assert.NotEmpty(employees);
    }

    [Fact]
    public void GetEmployee_WhenEmployeeSurnameIsDefined_ShouldReturnEmployeeBySurname()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employee = context.Employees.First();

        //Act
        var employees =
            employeeService.GetEmployees(c => c.Surname == employee.Surname, c => c.OrderBy(e => e.Id), 1, 10);


        //Assert
        Assert.NotEmpty(employees);
    }

    [Fact]
    public void GetEmployee_WhenEmployeePhoneNumberIsDefined_ShouldReturnEmployeeByPhoneNumber()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employee = context.Employees.First();

        //Act
        var employees = employeeService.GetEmployees(c => c.PhoneNumber == employee.PhoneNumber,
            c => c.OrderBy(e => e.Id), 1, 10);

        //Assert
        Assert.NotEmpty(employees);
    }

    [Fact]
    public void GetEmployee_WhenEmployeePassportDetailsIsDefined_ShouldReturnEmployeeByPassportDetails()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employee = context.Employees.First();

        //Act
        var employees = employeeService.GetEmployees(c => c.PassportDetails == employee.PassportDetails,
            c => c.OrderBy(e => e.Id), 1, 10);
        //Assert
        Assert.NotEmpty(employees);
    }

    [Fact]
    public void GetEmployee_WhenEmployeeStartAndEndDatesAreDefined_ShouldReturnEmployeeByStartAndEndDates()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employee = context.Employees.First();
        var start = DateTime.MinValue;
        var end = DateTime.Now;

        //Act
        var employees = employeeService.GetEmployees(c => c.StartDate >= start && c.EndDate <= end,
            c => c.OrderBy(e => e.Id), 1, 10);

        //Assert
        Assert.NotEmpty(employees);
    }

    [Fact]
    public void GetEmployee_WhenEverythingIsDefined_ShouldReturnEmployeeByAllParameters()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employee = context.Employees.First();
        var start = DateTime.MinValue;
        var end = DateTime.Now;

        //Act
        var employees = employeeService.GetEmployees(c => c.Name == employee.Name && c.Surname == employee.Surname &&
                                                          c.PhoneNumber == employee.PhoneNumber &&
                                                          c.PassportDetails == employee.PassportDetails &&
                                                          c.StartDate >= start && c.EndDate <= end,
            c => c.OrderBy(e => e.Id), 1, 10);

        //Assert
        Assert.NotEmpty(employees);
    }

    [Fact]
    public void UpdateEmployee_WhenEmployeeIsValid_ShouldUpdateEmployee()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employee = context.Employees.First();
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
            PassportDetails = "Passport Details",
            EndDate = DateTime.Now.AddYears(1)
        };

        //Act
        employeeService.UpdateEmployee(employee, employeeSasha);

        //Assert
        Assert.NotNull(employeeService.GetEmployeeById(employeeSasha.Id));
    }

    [Fact]
    public void UpdateEmployee_WhenEmployeeIsNull_ShouldThrowArgumentNullException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        Employee employeeSasha = null;
        Employee employeeIvan = null;

        //Act
        try
        {
            employeeService.UpdateEmployee(employeeIvan, employeeSasha);
        }
        catch (ArgumentNullException e)
        {
            //Assert
            Assert.True(e != null);
        }
    }

    [Fact]
    public void UpdateEmployee_WhenEmployeeNotFound_ShouldThrowArgumentException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
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
            PassportDetails = "Passport Details",
            EndDate = DateTime.Now.AddYears(1)
        };
        var employeeIvan = new Employee
        {
            Name = "Ivan",
            Surname = "Macarin",
            Email = "copyemail@mgamil.com",
            PhoneNumber = "123456789",
            BirthDate = new DateTime(1990, 1, 1),
            Address = "Bender",
            Position = "Developer",
            Salary = 1000m,
            PassportDetails = "Passport Details",
            EndDate = DateTime.Now.AddYears(1)
        };

        //Act
        try
        {
            employeeService.UpdateEmployee(employeeSasha, employeeIvan);
        }
        catch (ArgumentException e)
        {
            //Assert
            Assert.True(e != null);
        }
    }

    [Fact]
    public void RemoveEmployee_WhenEmployeeIsValid_ShouldRemoveEmployee()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employee = context.Employees.First();

        //Act
        employeeService.RemoveEmployee(employee);

        //Assert
        Assert.Null(employeeService.GetEmployeeById(employee.Id));
    }

    [Fact]
    public void RemoveEmployee_WhenEmployeeIsNull_ShouldThrowArgumentNullException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        Employee employeeIvan = null;

        //Act
        try
        {
            employeeService.RemoveEmployee(employeeIvan);
        }
        catch (ArgumentNullException e)
        {
            //Assert
            Assert.True(e != null);
        }
    }
}