using System.ComponentModel.DataAnnotations;
using BankSystem.App.Services;
using BankSystem.Appl.Exceptions;
using BankSystem.Appl.Interfaces;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;
using Microsoft.EntityFrameworkCore;

namespace BancSystem.App.Test;

public class ClientServiceTests
{
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
        clientService.AddClient(client);

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
            clientService.AddClient(client);
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
            clientService.AddClient(client);
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
            clientService.AddClient(client);
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
        var client = clientService.GetClients(c => true, c => c.OrderBy(c => c.Id), 1, 1).First();
        var account = new Account
        {
        };

        //Act
        try
        {
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
            clientService.AddClient(client);
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

        //Act
        var clients = clientService.GetClients(c => c.Name == client.Name, c => c.OrderBy(c => c.Name), 1, 10);

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

        //Act
        var clients = clientService.GetClients(c => c.Surname == client.Surname, c => c.OrderBy(c => c.Surname), 1, 10);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetClients_WhenClientPhoneNumberIsDefined_ShouldReturnClientAccountsByPhoneNumber()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = context.Clients.First();

        //Act
        var clients = clientService.GetClients(c => c.PhoneNumber == client.PhoneNumber,
            c => c.OrderBy(c => c.PassportDetails), 1, 10);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetClients_WhenClientPassportDetailsIsDefined_ShouldReturnClientAccountsByPassportDetails()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = context.Clients.First();

        //Act
        var clients = clientService.GetClients(c => c.PassportDetails == client.PassportDetails,
            c => c.OrderBy(c => c.PhoneNumber), 1, 10);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetClients_WhenClientStartAndEndDatesAreDefined_ShouldReturnClientAccountsByDates()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var start = DateTime.MinValue.ToUniversalTime();
        var end = DateTime.Now.ToUniversalTime();

        //Act
        var clients = clientService.GetClients(c => c.BirthDate >= start && c.BirthDate <= end,
            c => c.OrderBy(c => c.BirthDate), 1, 10);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetClients_WhenEverythingIsDetermined_ShouldReturnClientAccountsByAllParameters()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var clientStorage = new ClientStorage(context);
        var clientService = new ClientService(clientStorage);
        var client = context.Clients.First();
        var start = DateTime.MinValue.ToUniversalTime();
        var end = DateTime.Now.ToUniversalTime();


        //Act
        var clients = clientService.GetClients(c => c.Name == client.Name && c.Surname == client.Surname &&
                                                    c.PhoneNumber == client.PhoneNumber &&
                                                    c.PassportDetails == client.PassportDetails &&
                                                    c.BirthDate >= start && c.BirthDate <= end,
            c => c.OrderBy(c => c.Id), 1, 10);

        //Assert
        Assert.NotEmpty(clients);
    }
}