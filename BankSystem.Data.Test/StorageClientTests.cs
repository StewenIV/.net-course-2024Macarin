using BankSystem.App.Services;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Data.Test;

public class StorageClientTests
{
    [Fact]
    public void AddClient_ShouldAddClient_WhenClientIsValid()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        context.Clients.AddRangeAsync(TestDataGenerator.GenerateClients(10));
        context.SaveChanges();
        var storage = new ClientStorage(context);
        var clientIvan = new Client
        {
            Name = "Ivan",
            Surname = "Ivanov",
            Email = "akjsd@gmail.com",
            PhoneNumber = "123456789",
            BirthDate = new DateTime(1990, 1, 1),
            Address = "Tiraspol",
            OrderNumber = 1,
            OrderAmount = 1000m
        };

        // Act
        storage.Add(clientIvan);

        // Assert
        Assert.NotNull(storage.GetById(clientIvan.Id));
    }

    [Fact]
    public void AddClient_ShouldThrowArgumentNullException_WhenClientIsNull()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        context.Clients.AddRangeAsync(TestDataGenerator.GenerateClients(10));
        context.SaveChanges();
        var storage = new ClientStorage(context);
        Client clientIvan = null;

        //Act
        var exception = Record.Exception(() => storage.Add(clientIvan));

        //Assert
        Assert.True(exception is ArgumentNullException);
    }

    [Fact]
    public void AddClient_ShouldThrowArgumentException_WhenClientAlreadyExists()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        context.Clients.AddRangeAsync(TestDataGenerator.GenerateClients(10));
        context.SaveChanges();
        var storage = new ClientStorage(context);
        var client = storage.GetById(context.Clients.First()!.Id);

        // Act
        var exception = Record.Exception(() => storage.Add(client));

        // Assert
        Assert.True(exception is ArgumentException);
    }

    [Fact]
    public void GetClients_ShouldReturnClients_WhenClientsIsValid()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new ClientStorage(context);
        var client = storage.GetById(context.Clients.First()!.Id);

        // Act
        var result = storage.GetById(client.Id);

        // Assert
        Assert.NotNull(result);
    }

    [Fact]
    public void UpdateClient_ShouldUpdateClient_WhenClientIsValid()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new ClientStorage(context);
        var client = context.Clients.First();
        var clientIvan = new Client
        {
            Name = "Ivan",
            Surname = "Ivanov",
            Email = "akjsd@gmail.com",
            PhoneNumber = "123456789",
            BirthDate = new DateTime(1990, 1, 1),
            Address = "Tiraspol",
            OrderNumber = 1,
            OrderAmount = 1000m
        };
        
        // Act
        storage.Update(client!.Id, clientIvan);
        
        // Assert
        Assert.NotNull(storage.GetById(clientIvan.Id));
    }

    [Fact]
    public void UpdateClient_ShouldThrowArgumentNullException_WhenClientsIsNull()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new ClientStorage(context);
        Client oldClient = null;
        Client newClient = null;
        
        // Act
        var exception = Record.Exception(() => storage.Update(oldClient.Id, newClient));
        
        // Assert
        Assert.True(exception is ArgumentNullException);
    }

    [Fact]
    public void RemoveClient_ShouldRemoveClient_WhenClientExists()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new ClientStorage(context);
        var client = context.Clients.First();

        // Act
        storage.Delete(client!.Id);

        // Assert
        Assert.Null(storage.GetById(client.Id));
    }

    [Fact]
    public void RemoveClient_ShouldThrowArgumentNullException_WhenClientIsNull()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new ClientStorage(context);
        Client employeeIvan = null;

        // Act
        var exception = Record.Exception(() => storage.Delete(employeeIvan.Id));

        // Assert
        Assert.True(exception is ArgumentNullException);
    }

    [Fact]
    public void RemoveClient_ShouldThrowArgumentException_WhenClientNotFound()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new ClientStorage(context);
        var clientIvan = new Client
        {
            Name = "Ivan",
            Surname = "Ivanov",
            Email = "akjsd@gmail.com",
            PhoneNumber = "123456789",
            BirthDate = new DateTime(1990, 1, 1),
            Address = "Tiraspol",
            OrderNumber = 1,
            OrderAmount = 1000m
        };

        // Act
        var exception = Record.Exception(() => storage.Delete(clientIvan.Id));

        //Assert
        Assert.True(exception is ArgumentException);
    }
    
    [Fact]
    public void AddAccount_ShouldAddAccount_WhenAccountIsValid()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new ClientStorage(context);
        var client = context.Clients.First();
        var account = new Account
        {
            Currency = new Currency
            {
                Name = "Dollar",
                Code = CurrencyCode.Usd
            },
            Amount = 0m
        };
        
        // Act
        storage.AddAccount(client!.Id, account);
        
        // Assert
        Assert.Contains(account, storage.GetById(client.Id).Accounts);
    }
    
    [Fact]
    public void UpdateAccount_ShouldUpdateAccount_WhenAccountIsValid()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new ClientStorage(context);
        var oldAccount = context.Clients.Include(client => client.Accounts).First().Accounts.First();
        var client = context.Clients.First();
        var newAccount = new Account
        {
            Currency = new Currency
            {
                Name = "Dollar",
                Code = CurrencyCode.Usd
            },
            Amount = 100m
        };
        
        // Act
        storage.UpdateAccount(client!.Id, oldAccount.Id, newAccount);
        
        // Assert
        Assert.Contains(newAccount, storage.GetById(client.Id).Accounts);
    }
    
    [Fact]
    public void RemoveAccount_ShouldRemoveAccount_WhenAccountIsValid()
    {
        // Arrange
        using var context = new BankSystemDbContext();
        var storage = new ClientStorage(context);
        var client = context.Clients.First();
        var account = new Account
        {
            Currency = new Currency
            {
                Name = "Dollar",
                Code = CurrencyCode.Usd
            },
            Amount = 0m
        };
        storage.AddAccount(client!.Id, account);
        
        // Act
        storage.RemoveAccount(client!.Id, account.Id);
        
        // Assert
        Assert.DoesNotContain(account, storage.GetById(client.Id).Accounts);
    }
}