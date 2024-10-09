using BankSystem.App.Services;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;

namespace BankSystem.Data.Test;

public class StorageClientTests
{
    [Fact]
    public void AddClient_ShouldAddClient_WhenClientIsValid()
    {
        // Arrange
        var clients = new Dictionary<Client, List<Account>>();
        var storage = new ClientStorage(clients);
        var clientIvan = new Client
        {
            Name = "Ivan",
            Surname = "Ivanov",
            Email = "akjsd@gmail.com",
            PhoneNumber = "123456789",
            Age = 25,
            Address = "Tiraspol",
            OrderNumber = 1,
            OrderAmount = 1000m
        };

        // Act
        storage.Add(clientIvan);

        // Assert
        Assert.Contains(clientIvan, clients);
    }

    [Fact]
    public void AddClient_ShouldThrowArgumentNullException_WhenClientIsNull()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);
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
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);
        var client = clients.First();

        // Act
        var exception = Record.Exception(() => storage.Add(client));

        // Assert
        Assert.True(exception is ArgumentException);
    }

    [Fact]
    public void GetClients_ShouldReturnClients_WhenClientsIsValid()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);
        var client = clients.First();

        // Act
        var result = storage.Get(c => c.Name == client.Name);

        // Assert
        Assert.NotEmpty(result);
    }
    
    [Fact]
    public void GetClients_ShouldReturnClients_WhenClientsIsValidAndFilterIsNull()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);

        // Act
        var exception = Record.Exception(()=>storage.Get(null));

        // Assert
        Assert.True(exception is ArgumentNullException);
    }

    [Fact]
    public void UpdateClient_ShouldUpdateClient_WhenClientIsValid()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);
        var client = clients.First();
        var clientIvan = new Client
        {
            Name = "Ivan",
            Surname = "Ivanov",
            Email = "akjsd@gmail.com",
            PhoneNumber = "123456789",
            Age = 25,
            Address = "Tiraspol",
            OrderNumber = 1,
            OrderAmount = 1000m
        };
        
        // Act
        storage.Update(client, clientIvan);
        
        // Assert
        Assert.Contains(clientIvan, storage.Get(c => Equals(c, clientIvan)));
    }

    [Fact]
    public void UpdateClient_ShouldThrowArgumentNullException_WhenClientsIsNull()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);
        Client oldClient = null;
        Client newClient = null;
        
        // Act
        var exception = Record.Exception(() => storage.Update(oldClient, newClient));
        
        // Assert
        Assert.True(exception is ArgumentNullException);
    }

    [Fact]
    public void RemoveClient_ShouldRemoveClient_WhenClientExists()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);
        var client = clients.First();

        // Act
        storage.Delete(client);

        // Assert
        Assert.Empty( storage.Get(c => Equals(c, client)));
    }

    [Fact]
    public void RemoveClient_ShouldThrowArgumentNullException_WhenClientIsNull()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);
        Client employeeIvan = null;

        // Act
        var exception = Record.Exception(() => storage.Delete(employeeIvan));

        // Assert
        Assert.True(exception is ArgumentNullException);
    }

    [Fact]
    public void RemoveClient_ShouldThrowArgumentException_WhenClientNotFound()
    {
        // Arrange
        var clientIvan = new Client
        {
            Name = "Ivan",
            Surname = "Ivanov",
            Email = "akjsd@gmail.com",
            PhoneNumber = "123456789",
            Age = 25,
            Address = "Tiraspol",
            OrderNumber = 1,
            OrderAmount = 1000m
        };
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);

        // Act
        var exception = Record.Exception(() => storage.Delete(clientIvan));

        //Assert
        Assert.True(exception is ArgumentException);
    }
    
    [Fact]
    public void AddAccount_ShouldAddAccount_WhenAccountIsValid()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);
        var client = clients.First();
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
        storage.AddAccount(client, new List<Account>{account});
        
        // Assert
        Assert.Contains(account, storage.Get(c => Equals(c, client)).Values.First());
    }
    
    [Fact]
    public void UpdateAccount_ShouldUpdateAccount_WhenAccountIsValid()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);
        var client = persons.Keys.First();
        var oldAccount = persons.Values.First().First();
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
        storage.UpdateAccount(client, oldAccount, newAccount);
        
        // Assert
        Assert.Equal(100m, storage.Get(c => Equals(c, client)).Values.First().Last().Amount);
    }
    
    [Fact]
    public void RemoveAccount_ShouldRemoveAccount_WhenAccountIsValid()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);
        var client = clients.First();
        var account = new Account
        {
            Currency = new Currency
            {
                Name = "Dollar",
                Code = CurrencyCode.Usd
            },
            Amount = 0m
        };
        storage.AddAccount(client, new List<Account>{account});
        
        // Act
        storage.RemoveAccount(client, account);
        
        // Assert
        Assert.DoesNotContain(account, storage.Get(c => Equals(c, client)).Values.First());
    }
}