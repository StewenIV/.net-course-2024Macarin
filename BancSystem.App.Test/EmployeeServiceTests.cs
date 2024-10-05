using System.ComponentModel.DataAnnotations;
using BankSystem.App.Services;
using BankSystem.Appl.Exceptions;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;

namespace BancSystem.App.Test;

public class EmployeeServiceTests
{
    [Fact]
    public void AddEmployee_WhenEmployeeIsValid_ShouldAddEmployee()
    {
        //Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
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
            PassportDetails = "Passport Details",
            EndDate = DateTime.Now.AddYears(1)
        };

        //Act
        employeeService.AddEmployee(employeeSasha);

        //Assert
        Assert.Contains(employeeService.GetEmployees(employeeSasha.Name), emp =>
            emp.Currency.Name == "Dollar" && emp.Currency.Code == CurrencyCode.Usd);
        Assert.NotEmpty(employeeService.GetEmployees(employeeSasha.Name));
    }

    [Fact]
    public void AddEmployee_WhenEmployeeIsUnder18_ShouldThrowInvalidPersonAgeException()
    {
        //Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
        var employeeSasha = new Employee
        {
            Name = "Sasha",
            Surname = "Macarin",
            Email = "copyemail@mgamil.com",
            PhoneNumber = "123456789",
            Age = 17,
            Address = "Bender",
            Position = "Developer",
            Salary = 1000m,
            Currency = new Currency { Name = "Dollar", Code = CurrencyCode.Usd },
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
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
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
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
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
    public void GetYoungestEmployee_WhenEmployeeExists_ShouldReturnYoungestEmployee()
    {
        //Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
        var employee = employees.First();

        //Act
        var youngestEmployee = employeeService.GetYoungestEmployee(employee);

        //Assert
        Assert.Equal(employees.Min(emp => emp.Age), youngestEmployee.Age);
    }

    [Fact]
    public void GetYoungestEmployee_WhenEmployeeIsNull_ShouldThrowArgumentNullException()
    {
        //Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
        Employee employee = null;

        //Act
        try
        {
            employeeService.GetYoungestEmployee(employee);
        }
        catch (ArgumentNullException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void GetYoungestEmployee_WhenEmployeeDoesNotExist_ShouldThrowArgumentException()
    {
        //Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
        var employeeSasha = new Employee
        {
            Name = "Sasha",
            Surname = "Macarin",
            Email = "copyemail@mgamil.com",
            PhoneNumber = "123456789",
            Age = 17,
            Address = "Bender",
            Position = "Developer",
            Salary = 1000m,
            Currency = new Currency { Name = "Dollar", Code = CurrencyCode.Usd },
            PassportDetails = null,
            EndDate = DateTime.Now.AddYears(1)
        };

        //Act
        try
        {
            employeeService.GetYoungestEmployee(employeeSasha);
        }
        catch (ArgumentException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void GetEmployee_WhenEmployeeNameIsDefined_ShouldReturnEmployeeByName()
    {
        // Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
        var client = employees.First();

        //Act
        var clients = employeeService.GetEmployees(client.Name);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetEmployee_WhenEmployeeSurnameIsDefined_ShouldReturnEmployeeBySurname()
    {
        // Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
        var client = employees.First();

        //Act
        var clients = employeeService.GetEmployees(surname: client.Surname);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetEmployee_WhenEmployeePhoneNumberIsDefined_ShouldReturnEmployeeByPhoneNumber()
    {
        // Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
        var client = employees.First();

        //Act
        var clients = employeeService.GetEmployees(phoneNumber: client.PhoneNumber);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetEmployee_WhenEmployeePassportDetailsIsDefined_ShouldReturnEmployeeByPassportDetails()
    {
        // Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
        var client = employees.First();

        //Act
        var clients = employeeService.GetEmployees(passportDetails: client.PassportDetails);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetEmployee_WhenEmployeeStartAndEndDatesAreDefined_ShouldReturnEmployeeByStartAndEndDates()
    {
        // Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
        var start = DateTime.MinValue;
        var end = DateTime.Now;
        
        //Act
        var clients = employeeService.GetEmployees(start: start, end: end);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetEmployee_WhenEmployeeIsNotDefined_ShouldReturnAllEmployees()
    {
        // Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);

        //Act
        var clients = employeeService.GetEmployees();

        //Assert
        Assert.NotEmpty(clients);
    }
    
    [Fact] 
    public void GetEmployee_WhenEverythingIsDefined_ShouldReturnEmployeeByAllParameters()
    {
        // Arrange
        var employees = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employees);
        var employeeService = new EmployeeService(storage);
        var client = employees.First();
        var start = DateTime.MinValue;
        var end = DateTime.Now;

        //Act
        var clients = employeeService.GetEmployees(client.Name, client.Surname, client.PhoneNumber, client.PassportDetails, start, end);

        //Assert
        Assert.NotEmpty(clients);
    }

}