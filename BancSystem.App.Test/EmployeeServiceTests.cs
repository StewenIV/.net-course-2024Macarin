using System.ComponentModel.DataAnnotations;
using AutoMapper;
using BankSystem.App.Services;
using BankSystem.Appl.DTOs;
using BankSystem.Appl.Exceptions;
using BankSystem.Appl.Mapping;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;

namespace BancSystem.App.Test;

public class EmployeeServiceTests
{
    private IMapper _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()));
    [Fact]
    public void AddEmployee_WhenEmployeeIsValid_ShouldAddEmployee()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employeeSasha = TestDataGenerator.GenerateEmployees(1).First();
        employeeSasha.BirthDate = new DateTime(1990,1,1,0,0,0,DateTimeKind.Utc);
        
        //Act
        var employeeDto = _mapper.Map<EmployeeDto>(employeeSasha);
        employeeService.Add(employeeDto);

        //Assert
        Assert.NotNull(employeeService.GetById(employeeSasha.Id));
    }

    [Fact]
    public void AddEmployee_WhenEmployeeIsUnder18_ShouldThrowInvalidPersonAgeException()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employeeSasha = TestDataGenerator.GenerateEmployees(1).First();
        employeeSasha.BirthDate = new DateTime(1990,1,1,0,0,0,DateTimeKind.Utc);

        //Act
        try
        {
            var employeeDto = _mapper.Map<EmployeeDto>(employeeSasha);
            employeeService.Add(employeeDto);
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
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        var employeeSasha = TestDataGenerator.GenerateEmployees(1).First();
        employeeSasha.BirthDate = new DateTime(1990,1,1,0,0,0,DateTimeKind.Utc);

        //Act
        try
        {
            var employeeDto = _mapper.Map<EmployeeDto>(employeeSasha);
            employeeService.Add(employeeDto);
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
            var employeeDto = _mapper.Map<EmployeeDto>(employeeSasha);
            employeeService.Add(employeeDto);
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
        var employeeSearchParameters = new EmployeeSearchParametrs
        {
            Name = employee.Name
        };

        //Act
        var employees = employeeService.Get(employeeSearchParameters, 1, 10);

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
        var employeeSearchParameters = new EmployeeSearchParametrs
        {
            Name = employee.Surname
        };

        //Act
        var employees =
            employeeService.Get(employeeSearchParameters, 1, 10);


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
        var start = DateTime.MinValue.ToUniversalTime();
        var end = DateTime.Now.ToUniversalTime();
        var employeeSearchParameters = new EmployeeSearchParametrs
        {
            SortBy = OrderByForEmployee.Null
        };

        //Act
        var employees = employeeService.Get(employeeSearchParameters, 3, 50);

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
        var employeeSasha = TestDataGenerator.GenerateEmployees(1).First();
        employeeSasha.BirthDate = new DateTime(1990,1,1,0,0,0,DateTimeKind.Utc);
        var employeeDto = _mapper.Map<EmployeeDto>(employeeSasha);

        //Act
        employeeService.Update(employee.Id, employeeDto);

        //Assert
        Assert.NotNull(employeeService.GetById(employee.Id));
    }

    [Fact]
    public void UpdateEmployee_WhenEmployeeIsNull_ShouldThrowArgumentNullException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new EmployeeStorage(context);
        var employeeService = new EmployeeService(storage);
        EmployeeDto employeeSasha = null;
        Employee employeeIvan = null;

        //Act
        try
        {
            employeeService.Update(employeeIvan.Id, employeeSasha);
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
        var employeeSasha = TestDataGenerator.GenerateEmployees(1).First();
        employeeSasha.BirthDate = new DateTime(1990,1,1,0,0,0,DateTimeKind.Utc);
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
            var employeeDto = _mapper.Map<EmployeeDto>(employeeSasha);
            employeeService.Update(employeeSasha.Id, employeeDto);
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
        employeeService.Remove(employee.Id);
        var exception = Record.Exception(() => employeeService.GetById(employee.Id));

        //Assert
        Assert.True(exception is ArgumentException);
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
            employeeService.Remove(employeeIvan.Id);
        }
        catch (ArgumentNullException e)
        {
            //Assert
            Assert.True(e != null);
        }
    }
}