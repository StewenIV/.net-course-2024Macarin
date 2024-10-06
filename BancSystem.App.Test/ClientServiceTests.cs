using System.ComponentModel.DataAnnotations;
using BankSystem.App.Services;
using BankSystem.Appl.Exceptions;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;

namespace BancSystem.App.Test;

public class ClientServiceTests
{
    [Fact]
    public void AddClient_WhenClientIsValid_ShouldAddClient()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = new Client
        {
            Name = "Sasha",
            Surname = "Surname",
            PhoneNumber = "+7 812 602-03-30",
            Email = "asdlkad@gmail.com",
            Age = 18,
            Address = "Address",
            OrderNumber = 1,
            OrderAmount = 1,
            PassportDetails = "PassportDetails"
        };

        //Act
        clientService.AddClient(client);

        //Assert
        Assert.Contains(clientService.GetClients(client.Name).Values, account =>
            account[0].Currency.Name == "Dollar" && account[0].Currency.Code == CurrencyCode.Usd);
        Assert.NotEmpty(clientService.GetClients(client.Name));
    }

    [Fact]
    public void AddClient_WhenClientIsNotValid_ShouldThrowValidationException()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = new Client
        {
            Surname = "Surname",
            PhoneNumber = "PhoneNumber",
            Email = "Email",
            Age = 18,
            Address = "Address",
            OrderNumber = 1,
            OrderAmount = 1
        };

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
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = new Client
        {
            Name = "Sasha",
            Surname = "Surname",
            PhoneNumber = "+7 812 602-03-30",
            Email = "asdlkad@gmail.com",
            Age = 17,
            Address = "Address",
            OrderNumber = 1,
            OrderAmount = 1,
            PassportDetails = "PassportDetails"
        };

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
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = new Client
        {
            Name = "Sasha",
            Surname = "Surname",
            PhoneNumber = "+7 812 602-03-30",
            Email = "asdlkad@gmail.com",
            Age = 18,
            Address = "Address",
            OrderNumber = 1,
            OrderAmount = 1,
            PassportDetails = null,
        };

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
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
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
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = new Client();

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
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = new Client();

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
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = clientAccounts.First().Key;
        var account = new Account
        {
            Currency = new Currency
            {
                Name = "Dollar",
                Code = CurrencyCode.Usd
            },
            Amount = -1
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
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        Client client = null;
        var account = new Account();

        //Act
        try
        {
            clientService.UpdateAccount(client, account);
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
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = clientAccounts.First().Key;
        Account account = null;

        //Act
        try
        {
            clientService.UpdateAccount(client, account);
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
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = new Client();
        var account = new Account();

        //Act
        try
        {
            clientService.UpdateAccount(client, account);
        }
        catch (ArgumentException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void UpdateAccount_WhenUpdateAccountIsNotValid_ShouldArgumentException()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var updateAccount = new Account
        {
            Currency = new Currency
            {
                Name = "Euro",
                Code = CurrencyCode.Eur
            },
            Amount = -1
        };

        //Act
        try
        {
            clientService.UpdateAccount(clientAccounts.First().Key, updateAccount);
        }
        catch (ArgumentException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void UpdateAccount_WhenExistingAccountIsNotValid_ShouldTrowValidationException()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var clientSasha = new Client
        {
            Name = "Sasha",
            Surname = "Surname",
            PhoneNumber = "+7 812 602-03-30",
            Email = "asdlkad@gmail.com",
            Age = 18,
            Address = "Address",
            OrderNumber = 1,
            OrderAmount = 1,
            PassportDetails = "PassportDetails"
        };
        var account = new Account
        {
            Currency = new Currency
            {
                Name = "Dollar",
                Code = CurrencyCode.Usd
            },
        };

        //Act
        try
        {
            clientService.AddClient(clientSasha);
            clientService.UpdateAccount(clientSasha, account);
        }
        catch (ValidationException exception)
        {
            //Assert
            Assert.True(exception != null);
        }
    }

    [Fact]
    public void UpdateAccount_WhenAccountIsValid_ShouldUpdateAccount()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var clientSasha = new Client
        {
            Name = "Sasha",
            Surname = "Surname",
            PhoneNumber = "+7 812 602-03-30",
            Email = "asdlkad@gmail.com",
            Age = 18,
            Address = "Address",
            OrderNumber = 1,
            OrderAmount = 1,
            PassportDetails = "PassportDetails"
        };
        var account = new Account
        {
            Currency = new Currency
            {
                Name = "Dollar",
                Code = CurrencyCode.Usd
            },
            Amount = 1000m
        };

        //Act
        clientService.AddClient(clientSasha);
        clientService.UpdateAccount(clientSasha, account);

        //Assert
        Assert.Contains(clientService.GetClients(clientSasha.Name).Values, acc =>
            acc[0].Currency.Name == "Dollar" && acc[0].Currency.Code == CurrencyCode.Usd && acc[0].Amount == 1000m);
    }

    [Fact]
    public void GetClients_WhenClientNameIsDefined_ShouldReturnClientAccountsByName()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = clientAccounts.First().Key;

        //Act
        var clients = clientService.GetClients(client.Name);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetClients_WhenClientSurnameIsDefined_ShouldReturnClientAccountsBySurname()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = clientAccounts.First().Key;

        //Act
        var clients = clientService.GetClients(surname: client.Surname);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetClients_WhenClientPhoneNumberIsDefined_ShouldReturnClientAccountsByPhoneNumber()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = clientAccounts.First().Key;

        //Act
        var clients = clientService.GetClients(phoneNumber: client.PhoneNumber);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetClients_WhenClientPassportDetailsIsDefined_ShouldReturnClientAccountsByPassportDetails()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = clientAccounts.First().Key;

        //Act
        var clients = clientService.GetClients(passportDetails: client.PassportDetails);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetClients_WhenClientStartAndEndDatesAreDefined_ShouldReturnClientAccountsByDates()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var start = DateTime.MinValue;
        var end = DateTime.Now;

        //Act
        var clients = clientService.GetClients(start: start, end: end);

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetClients_WhenClientIsNotDefined_ShouldReturnAllClientAccounts()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);

        //Act
        var clients = clientService.GetClients();

        //Assert
        Assert.NotEmpty(clients);
    }

    [Fact]
    public void GetClients_WhenEverythingIsDetermined_ShouldReturnClientAccountsByAllParameters()
    {
        // Arrange
        var clientAccounts = TestDataGenerator.GenerateDictionary(TestDataGenerator.GenerateClients());
        var clientStorage = new ClientStorage(clientAccounts);
        var clientService = new ClientService(clientStorage);
        var client = clientAccounts.First().Key;
        var start = DateTime.MinValue;
        var end = DateTime.Now;


        //Act
        var clients = clientService.GetClients(client.Name, client.Surname, client.PhoneNumber, client.PassportDetails,
            start, end);

        //Assert
        Assert.NotEmpty(clients);
    }
}