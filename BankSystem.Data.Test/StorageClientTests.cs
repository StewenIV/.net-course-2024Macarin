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
        var accounts = new List<Account>()
        {
            new Account()
            {
                Amount = 1000m,
                Currency = new Currency() { Code = CurrencyCode.Usd, Name = "Dollar" }
            },
            new Account()
            {
                Amount = 1000m,
                Currency = new Currency() { Code = CurrencyCode.Eur, Name = "Euro" }
            }
        };
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
        storage.AddClient(clientIvan, accounts);

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
        var exception = Record.Exception(() => storage.AddClient(clientIvan, new List<Account>()));

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
        var exception = Record.Exception(() => storage.AddClient(client, new List<Account>()));

        // Assert
        Assert.True(exception is ArgumentException);
    }

    [Fact]
    public void GetYoungestClient_ShouldReturnYoungestClient_WhenClientsExist()
    {
        // Arrange
        var clients = TestDataGenerator.GenerateClients();
        var persons = TestDataGenerator.GenerateDictionary(clients);
        var storage = new ClientStorage(persons);

        // Act
        var result = storage.GetYoungestClient();

        // Assert
        Assert.Equal(clients.Min(c => c.Age), result.Age);
    }

    [Fact]
    public void GetYoungestClient_ShouldThrowInvalidOperationException_WhenNoClientsExist()
    {
        //Arrange
        var clients = new Dictionary<Client, List<Account>>();
        var storage = new ClientStorage(clients);

        //Act 
        var exception = Record.Exception(() => storage.GetYoungestClient());

        //Assert
        Assert.True(exception is InvalidOperationException);
    }

    [Fact]
    public void GetOldestClient_ShouldReturnOldestClient_WhenClientsExist()
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
        var clientSasha = new Client
        {
            Name = "Sasha",
            Surname = "Ivanov",
            Email = "akjsd@gmail.com",
            PhoneNumber = "123456789",
            Age = 25,
            Address = "Tiraspol",
            OrderNumber = 1,
            OrderAmount = 1000m,
        };
        var clients = new Dictionary<Client, List<Account>>()
        {
            {clientIvan, new List<Account>()},
            {clientSasha, new List<Account>()}
        };
        var storage = new ClientStorage(clients);

        // Act
        var result = storage.GetOldestClient();

        // Assert
        Assert.Equal(clients.Max(c => c.Key.Age), result.Age);
    }

    [Fact]
    public void GetOldestClient_ShouldThrowInvalidOperationException_WhenNoClientsExist()
    {
        // Arrange
        var clients = new Dictionary<Client, List<Account>>();
        var storage = new ClientStorage(clients);

        // Act
        var exception = Record.Exception(() => storage.GetOldestClient());

        // Assert
        Assert.True(exception is InvalidOperationException);
    }

    [Fact]
    public void GetAverageAge_ShouldReturnAverageAge_WhenClientsExist()
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
        var clientSasha = new Client
        {
            Name = "Sasha",
            Surname = "Ivanov",
            Email = "akjsd@gmail.com",
            PhoneNumber = "123456789",
            Age = 25,
            Address = "Tiraspol",
            OrderNumber = 1,
            OrderAmount = 1000m,
        };
        var clients = new Dictionary<Client, List<Account>>()
        {
            {clientIvan, new List<Account>()},
            {clientSasha, new List<Account>()}
        };
        var storage = new ClientStorage(clients);

        // Act
        var result = storage.GetAverageAge();

        // Assert
        Assert.Equal(25, result);
    }

    [Fact]
    public void GetAverageAge_ShouldThrowInvalidOperationException_WhenNoClientsExist()
    {
        // Arrange
        var clients = new Dictionary<Client, List<Account>>();
        var storage = new ClientStorage(clients);

        // Act
        var exception = Record.Exception(() => storage.GetAverageAge());

        // Assert
        Assert.True(exception is InvalidOperationException);
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
        storage.RemoveClient(client);

        // Assert
        Assert.DoesNotContain(client, storage.Clients);
    }

    [Fact]
    public void RemoveClient_ShouldThrowArgumentNullException_WhenClientIsNull()
    {
        // Arrange
        var employee = TestDataGenerator.GenerateEmployees();
        var storage = new EmployeeStorage(employee);
        Employee employeeIvan = null;

        // Act
        var exception = Record.Exception(() => storage.RemoveEmployee(employeeIvan));

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
        var exception = Record.Exception(() => storage.RemoveClient(clientIvan));

        //Assert
        Assert.True(exception is ArgumentException);
    }
}