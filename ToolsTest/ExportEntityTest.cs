using BankSystem.App.Services;
using BankSystem.Appl.DTOs;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;
using ExportTool;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace ExportToolTests;

public class ExportEntityTest
{
    [Fact]
    public void ExportClients_ShouldExportEntity_WhenAllParametersAreValid()
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

        //Assert
        var filePath = Path.Combine(path, "clients.json");
        Assert.True(File.Exists(filePath));

        var fileInfo = new FileInfo(filePath);
        Assert.True(fileInfo.Length > 0);

        var pathSchema = Path.Combine(projectPath, "Schems", "ClientSchema.json");
        var schema = JSchema.Parse(File.ReadAllText(pathSchema));
        var fileContent = File.ReadAllText(filePath);
        var jsonArr = JArray.Parse(fileContent);
        foreach (var jsonOdj in jsonArr)
        {
            Assert.True(jsonOdj.IsValid(schema));
        }
    }

    [Fact]
    public void ExportClients_ShouldThrowArgumentException_WhenPathIsNull()
    {
        //Arrange
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);
        var clientSearchParameters = new ClientSearchParameters()
        {
            SortBy = OrderByForClient.Null
        };

        //Act
        var clients = service.Get(clientSearchParameters, 1, 10);

        //Assert
        Assert.Throws<ArgumentException>(() => ExportService.ExportEntityToJson(clients, String.Empty, "clients.json"));
    }

    [Fact]
    public void ExportClients_ShouldThrowArgumentException_WhenEntityIsNull()
    {
        //Arrange
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);

        //Act
        List<Client> clients = null;

        //Assert
        Assert.Throws<ArgumentNullException>(() => ExportService.ExportEntityToJson(clients, "path", "clients.json"));
    }

    [Fact]
    public void ExportClient_ShouldExportEntity_WhenAllParametersAreValid()
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
        var clients = service.Get(clientSearchParameters, 1, 1).First();
        ExportService.ExportEntityToJson(clients, path, "clients.json");

        //Assert
        var filePath = Path.Combine(path, "clients.json");
        Assert.True(File.Exists(filePath));

        var fileInfo = new FileInfo(filePath);
        Assert.True(fileInfo.Length > 0);

        var pathSchema = Path.Combine(projectPath, "Schems", "ClientSchema.json");
        var schema = JSchema.Parse(File.ReadAllText(pathSchema));
        var fileContent = File.ReadAllText(filePath);
        var jsonObj = JObject.Parse(fileContent);
        Assert.True(jsonObj.IsValid(schema));
    }
    
    [Fact]
    public void ExportEmployee_ShouldExportEntity_WhenAllParametersAreValid()
    {
        //Assert
        var projectPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
        var path = Path.Combine(projectPath, "Export");
        var dbContext = new BankSystemDbContext();
        var storage = new EmployeeStorage(dbContext);
        var service = new EmployeeService(storage);
        var employeeSearchParameters = new EmployeeSearchParametrs()
        {
            SortBy = OrderByForEmployee.Null
        };

        //Act
        var employee = service.Get(employeeSearchParameters, 1, 1).First();
        ExportService.ExportEntityToJson(employee, path, "employee.json");

        //Assert
        var filePath = Path.Combine(path, "employee.json");
        Assert.True(File.Exists(filePath));

        var fileInfo = new FileInfo(filePath);
        Assert.True(fileInfo.Length > 0);

        var pathSchema = Path.Combine(projectPath, "Schems", "EmployeeSchema.json");
        var schema = JSchema.Parse(File.ReadAllText(pathSchema));
        var fileContent = File.ReadAllText(filePath);
        var jsonObj = JObject.Parse(fileContent);
        Assert.True(jsonObj.IsValid(schema));
    }
    
}