using BankSystem.App.Services;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using ExportTool;

namespace ExportToolTests;

public class InportClientsTest
{
    [Fact]
    public void ImportClients_ShouldImportClients_WhenPathIsValid()
    {
        // Arrange
        var projectPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
        var path = Path.Combine(projectPath, "Import");
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);

        //Act 
        var clients = TestDataGenerator.GenerateClients(10);
        var fileName = "clients.csv";
        ExportService.ExportClientsToCsv(path, fileName, clients);
        ExportService.ImportClientsFromCsv(path, fileName);

        // Assert
        clients.Select(x => service.GetClientById(x.Id)).ToList().ForEach(x => Assert.NotNull(x));
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
        
        // Act
        var clients = service.GetClients(x => true, x => x.OrderBy(x => x.Id), 1, 10);
        
        // Assert
        Assert.Throws<ArgumentException>(() => ExportService.ImportClientsFromCsv(string.Empty, string.Empty));
        Assert.Throws<ArgumentException>(() => ExportService.ImportClientsFromCsv(string.Empty, "clients.csv"));
        Assert.Throws<ArgumentException>(() => ExportService.ImportClientsFromCsv(path, string.Empty));
    }
}