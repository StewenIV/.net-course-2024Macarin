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
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);
        
        // Act
        var clients = service.GetClients(x => true, x => x.OrderBy(x => x.Id), 1, 10);
        
        // Assert
        Assert.Throws<ArgumentException>(() => ExportService.ImportClientsFromCsv("", ""));
    }
    
    [Fact]
    public void ImportClients_ShouldThrowDirectoryNotFoundException_WhenPathIsInvalid()
    {
        // Arrange
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);
        
        // Act
        var clients = service.GetClients(x => true, x => x.OrderBy(x => x.Id), 1, 10);
        
        // Assert
        Assert.Throws<DirectoryNotFoundException>(() => ExportService.ImportClientsFromCsv("InvalidPath", "clients.csv"));
    }
    
    [Fact]
    public void ImportClients_ShouldThrowFileNotFoundException_WhenFileIsNotFound()
    {
        // Arrange
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);
        
        // Act
        var clients = service.GetClients(x => true, x => x.OrderBy(x => x.Id), 1, 10);
        
        // Assert
        Assert.Throws<FileNotFoundException>(() => ExportService.ImportClientsFromCsv(Directory.GetCurrentDirectory(), "clients.csv"));
    }
}