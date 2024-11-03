using BankSystem.App.Services;
using BankSystem.Appl.DTOs;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;
using ExportTool;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace ExportToolTests;

public class ImportEntityTest
{
    [Fact]
    public void ImportEntities_ShouldImportEntity_WhenAllParametersAreValid()
    {
        //Assert
        var projectPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
        var path = Path.Combine(projectPath, "Export");
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);
        var clientSearchParameters = new ClientSearchParameters()
        {
            SortBy = OrderByForClient.Null
        };

        //Act
        var clients = service.Get(clientSearchParameters, 1, 10);
        ExportService.ExportEntityToJson(clients, path, "clients.json");
        var importedСlients = ExportService.ImportEntityFromJson<List<Client>>(path, "clients.json");

        //Assert
        importedСlients.ForEach(x => Assert.NotNull(x));
    }

    [Fact]
    public void ImportClients_ShouldThrowArgumentException_WhenPathOrNameIsNullOrEmpty()
    {
        // Arrange
        var projectPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
        var path = Path.Combine(projectPath, "Import");
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);
        var clientSearchParameters = new ClientSearchParameters()
        {
            SortBy = OrderByForClient.Null
        };

        // Act
        var clients = service.Get(clientSearchParameters, 1, 10);

        // Assert
        Assert.Throws<ArgumentException>(() => ExportService.ImportEntityFromJson<Client>(string.Empty, string.Empty));
        Assert.Throws<ArgumentException>(() => ExportService.ImportEntityFromJson<Client>(string.Empty, "clients.csv"));
        Assert.Throws<ArgumentException>(() => ExportService.ImportEntityFromJson<Client>(path, string.Empty));
    }
    
    [Fact]
    public void ImportEmployees_ShouldImportEmployees_WhenPathIsValid()
    {
        // Arrange
        var projectPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
        var path = Path.Combine(projectPath, "Import");
        var dbContext = new BankSystemDbContext();
        var storage = new EmployeeStorage(dbContext);
        var service = new EmployeeService(storage);
        var employeeSearchParameters = new EmployeeSearchParametrs
        {
            SortBy = OrderByForEmployee.Null
        };
        
        //Act 
        var employees = service.Get(employeeSearchParameters, 1, 10);
        ExportService.ExportEntityToJson(employees, path, "employee.json");
        var importedEmployees = ExportService.ImportEntityFromJson<List<Employee>>(path, "employee.json");
        
        // Assert
        importedEmployees.ForEach(x => Assert.NotNull(x));
    }
}