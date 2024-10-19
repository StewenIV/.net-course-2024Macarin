using BankSystem.App.Services;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using ExportTool;

namespace ExportToolTests;

public class ExportClientsTest
{
    [Fact]
    public void ExportClients_ShouldExportClients_WhenPathIsValid()
    {
        // Arrange
        var projectPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
        var path = Path.Combine(projectPath, "Export");
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);
        
        // Act
        var clients = service.GetClients(x => true, x => x.OrderBy(x => x.Id), 1, 10);
        ExportService.ExportClientsToCsv(path, "clients.csv", clients);
        
        // Assert
        Assert.True(File.Exists(Path.Combine(path, "clients.csv")));
    }
    
    [Fact]
    public void ExportClients_ShouldThrowArgumentException_WhenPathOrNameIsNullOrEmpty()
    {
        // Arrange
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);
        
        // Act
        var clients = service.GetClients(x => true, x => x.OrderBy(x => x.Id), 1, 10);
        
        // Assert
        Assert.Throws<ArgumentException>(() => ExportService.ExportClientsToCsv("", "", clients));
    }
}