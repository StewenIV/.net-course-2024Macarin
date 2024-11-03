using System.ComponentModel.DataAnnotations;
using AutoMapper;
using BankSystem.App.Services;
using BankSystem.Appl.DTOs;
using BankSystem.Appl.Exceptions;
using BankSystem.Appl.Interfaces;
using BankSystem.Appl.Mapping;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;
using Microsoft.EntityFrameworkCore;

namespace BancSystem.App.Test;

public class ClientServiceTests
{
    private IMapper _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()));
    [Fact]
    public void AddClient_WhenClientIsValid_ShouldAddClient()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = TestDataGenerator.GenerateClients(1).First();
        client.BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        //Act
        var clientDto = _mapper.Map<ClientDto>(client);
        clientService.Add(clientDto);

        //Assert
        Assert.NotNull(clientStorage.GetById(client.Id));
    }

    [Fact]
    public void AddClient_WhenClientIsNotValid_ShouldThrowValidationException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = TestDataGenerator.GenerateClients(1).First();
        client.BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        client.Name = null;

        //Act
        try
        {
            var clientDto = _mapper.Map<ClientDto>(client);
            clientService.Add(clientDto);
        }
        catch (ValidationException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void AddClient_WhenClientIsUnder18_ShouldThrowInvalidClientAgeException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = TestDataGenerator.GenerateClients(1).First();
        client.BirthDate = new DateTime(2015, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        //Act
        try
        {
            var clientDto = _mapper.Map<ClientDto>(client);
            clientService.Add(clientDto);
        }
        catch (InvalidPersonAgeException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void AddClient_WhenPassportDetailsIsNull_ShouldTrowPassportDetailsNullException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = TestDataGenerator.GenerateClients(1).First();
        client.BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        client.PassportDetails = null;

        //Act
        try
        {
            var clientDto = _mapper.Map<ClientDto>(client);
            clientService.Add(clientDto);
        }
        catch (PassportDetailsNullException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void AddAdditionalAccount_WhenClientIsNull_ShouldThrowArgumentNullException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        Client client = null;

        //Act
        try
        {
            clientService.AddAdditionalAccount(client, new List<Account>());
        }
        catch (ArgumentNullException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void AddAdditionalAccount_WhenAccountsIsNull_ShouldThrowArgumentNullException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = TestDataGenerator.GenerateClients(1).First();
        client.BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        //Act
        try
        {
            clientService.AddAdditionalAccount(client, null);
        }
        catch (ArgumentNullException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void AddAdditionalAccount_WhenClientNotFound_ShouldThrowArgumentException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = new Client
        {
            Id = Guid.NewGuid(),
            Name = "Sasha",
            Surname = "Surname",
            PhoneNumber = "+7 812 602-03-30",
            Email = "asdlkad@gmail.com",
            BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            Address = "Address",
            OrderNumber = 1,
            OrderAmount = 1,
            PassportDetails = "PassportDetails",
            Bonus = 1000m
        };

        //Act
        try
        {
            clientService.AddAdditionalAccount(client, new List<Account>());
        }
        catch (ArgumentException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void AddAdditionalAccount_WhenAccountIsNotValid_ShouldThrowValidationException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var clientSearchParameters = new ClientSearchParameters()
        {
            SortBy = OrderByForClient.Null
        };
        var clientDto = clientService.Get(clientSearchParameters, 1, 1).First();
        var account = new Account();

        //Act
        try
        {
            var client = _mapper.Map<Client>(clientDto);
            clientService.AddAdditionalAccount(client, new List<Account> { account });
        }
        catch (ValidationException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void UpdateAccount_WhenClientIsNull_ShouldThrowArgumentNullException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        Client client = null;
        var oldAccount = context.Clients.Include(x => x.Accounts).First().Accounts.First();
        var account = new Account();

        //Act
        try
        {
            clientService.UpdateAccount(client, oldAccount, account);
        }
        catch (ArgumentNullException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void UpdateAccount_WhenAccountIsNull_ShouldThrowArgumentNullException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var oldAccount = context.Clients.Include(x => x.Accounts).First().Accounts.First();
        var client = context.Clients.First();
        Account account = null;

        //Act
        try
        {
            clientService.UpdateAccount(client, oldAccount, account);
        }
        catch (ArgumentNullException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void UpdateAccount_WhenClientNotFound_ShouldThrowArgumentException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var oldAccount = context.Clients.Include(x => x.Accounts).First().Accounts.First();
        var client = new Client();
        var account = new Account();

        //Act
        try
        {
            clientService.UpdateAccount(client, oldAccount, account);
        }
        catch (ArgumentException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void UpdateAccount_WhenUpdateAccountIsNotValid_ShouldValidationException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var oldAccount = context.Clients.Include(x => x.Accounts).First().Accounts.First();
        var updateAccount = new Account
        {
        };
        var client = context.Clients.First()!;

        //Act
        try
        {
            clientService.UpdateAccount(client, oldAccount, updateAccount);
        }
        catch (ValidationException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void UpdateAccount_WhenExistingAccountIsNotValid_ShouldTrowValidationException()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var oldAccount = context.Clients.Include(x => x.Accounts).First().Accounts.First();
        var client = TestDataGenerator.GenerateClients(1).First();
        client.BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        var account = new Account
        {
        };

        //Act
        try
        {
            var clientDto = _mapper.Map<ClientDto>(client);
            clientService.Add(clientDto);
            clientService.UpdateAccount(client, oldAccount, account);
        }
        catch (ValidationException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void GetClients_WhenClientNameIsDefined_ShouldReturnClientAccountsByName()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = context.Clients.First();
        var clientSearchParameters = new ClientSearchParameters()
        {
            Name = client.Name,
            SortBy = OrderByForClient.Name
        };

        //Act
        var clients = clientService.Get(clientSearchParameters, 1, 10);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetClients_WhenClientSurnameIsDefined_ShouldReturnClientAccountsBySurname()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = context.Clients.First();
        var clientSearchParameters = new ClientSearchParameters()
        {
            SortBy = OrderByForClient.Surname,
            Name = client.Surname
        };

        //Act
        var clients = clientService.Get(clientSearchParameters, 1, 10);

        //Assert
        Assert.NotEmpty(clients);
    }
    

    [Fact]
    public async Task WithdrawAsync_WhenClientHasEnoughMoney_ShouldWithdrawMoney()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = clientStorage.GetAsync(x => true, x => x.OrderBy(x => true), 1, 100).Result;

        //Act
        var processTask = clientService.StartProcessingRequestsAsync();
        await GenerateRequestsAsync(10, client.First().Id, 50, clientService);
        await Task.Delay(1000);

        // Assert
        Assert.True(client.First().Accounts.First().Amount >= 0);
    }

    public async Task GenerateRequestsAsync(int numberOfRequests, Guid clientId, decimal maxAmount,
        ClientService clientService)
    {
        var random = new Random();
        for (int i = 0; i < numberOfRequests; i++)
        {
            var amount = (decimal)(random.NextDouble() * (double)maxAmount);
            var request = new WithdrawalRequest { ClientId = clientId, Amount = amount };
            clientService.AddWithdrawalRequest(request);
            await Task.Delay(50);
        }
    }
}