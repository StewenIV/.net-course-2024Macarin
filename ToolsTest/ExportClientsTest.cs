using AutoMapper;
using BankSystem.App.Services;
using BankSystem.Appl.DTOs;
using BankSystem.Appl.Mapping;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;
using ExportTool;

namespace ExportToolTests;

public class ExportClientsTest
{
    private readonly IMapper _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()));

    [Fact]
    public void ExportClients_ShouldExportClients_WhenPathIsValid()
    {
        // Arrange
        var projectPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
        var path = Path.Combine(projectPath, "Export");
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);
        var clientSearchParameters = new ClientSearchParameters()
        {
            SortBy = OrderByForClient.Null
        };

        // Act
        var clientsDto = service.Get(clientSearchParameters, 1, 10);
        var clients = _mapper.Map<List<Client>>(clientsDto);
        ExportService.ExportClientsToCsv(path, "clients.csv", clients);

        // Assert
        var filePath = Path.Combine(path, "clients.csv");
        Assert.True(File.Exists(filePath));

        var fileInfo = new FileInfo(filePath);
        Assert.True(fileInfo.Length > 0);

        var fileContent = File.ReadAllText(filePath);
        Assert.Contains(
            "OrderNumber,OrderAmount,Id,Name,Surname,PhoneNumber,Email,Age,Address,PassportDetails,BirthDate,Bonus",
            fileContent, StringComparison.InvariantCultureIgnoreCase);
    }

    [Fact]
    public void ExportClients_ShouldThrowArgumentException_WhenPathOrNameIsNullOrEmpty()
    {
        // Arrange
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);
        var clientSearchParameters = new ClientSearchParameters()
        {
            SortBy = OrderByForClient.Null
        };

        // Act
        var clientsDto = service.Get(clientSearchParameters, 1, 10);
        var clients = _mapper.Map<List<Client>>(clientsDto);
        

        // Assert
        Assert.Throws<ArgumentException>(() => ExportService.ExportClientsToCsv(string.Empty, string.Empty, clients));
    }
}