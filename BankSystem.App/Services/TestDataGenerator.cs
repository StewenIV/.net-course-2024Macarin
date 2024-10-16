using BankSystem.Dom.Models;
using Bogus;
using Person = BankSystem.Dom.Models.Person;

namespace BankSystem.App.Services;

public class TestDataGenerator
{
    public static List<Client> GenerateClients(int count)
    {
        var orderNumber = 0;
        var personFaker = new Faker<Client>()
            .RuleFor(p => p.Id, f => f.Random.Guid())
            .RuleFor(p => p.Name, f => f.Name.FirstName())
            .RuleFor(p => p.Surname, f => f.Name.LastName())
            .RuleFor(p => p.Email, f => 
            {
                var email = f.Internet.Email();
                return email.Length > 50 ? email.Substring(0, 50) : email; 
            })
            .RuleFor(p => p.PhoneNumber, f => 
            {
                var phone = f.Phone.PhoneNumber();
                return phone.Length > 20 ? phone.Substring(0, 20) : phone; 
            })
            .RuleFor(p => p.Address, f => f.Address.Country())
            .RuleFor(p => p.OrderNumber, f => ++orderNumber)
            .RuleFor(p => p.OrderAmount, f => f.Random.Int(5, 10) * 100m)
            .RuleFor(p => p.BirthDate, f => f.Date.Past(99,DateTime.UtcNow))
            .RuleFor(p => p.PassportDetails, f => 
            {
                var passportDetails = f.Lorem.Sentence(2);
                return passportDetails.Length > 50 ? passportDetails.Substring(0, 50) : passportDetails;
            })
            .RuleFor(p => p.Bonus, f => f.Random.Decimal(0, 1000));
        return personFaker.Generate(count);
    }

    public static Dictionary<string, Client> GenerateClientsDictionary(List<Client> clients)
    {
        if (clients == null)
            throw new ArgumentNullException(nameof(clients));
        return clients.ToDictionary(c => c.PhoneNumber, c => c);
    }

    public static List<Employee> GenerateEmployees(int count)
    {
        var nameCurrency = new List<string>()
        {
            "Dollar",
            "Euro",
            "Rub",
        };
        var personFaker = new Faker<Employee>()
            .RuleFor(p => p.Id, f => f.Random.Guid())
            .RuleFor(p => p.Name, f => f.Name.FirstName())
            .RuleFor(p => p.Surname, f => f.Name.LastName())
            .RuleFor(p => p.Email, f => f.Internet.Email())
            .RuleFor(p => p.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(p => p.Address, f => f.Address.FullAddress())
            .RuleFor(p => p.Position, f => f.Name.JobTitle())
            .RuleFor(p => p.Salary, f => f.Random.Int(5, 20) * 100m)
            .RuleFor(p => p.StartDate, f => f.Date.Past(1))
            .RuleFor(p => p.EndDate, f => f.Date.Future())
            .RuleFor(p => p.PassportDetails, f => f.Lorem.Sentence())
            .RuleFor(p => p.Bonus, f => f.Random.Decimal(0, 1000))
            .RuleFor(p => p.BirthDate, f => f.Date.Past(99, DateTime.UtcNow));
        return personFaker.Generate(count);
    }

    public static Dictionary<Client, List<Account>> GenerateDictionary(List<Client> clients)
    {
        if (clients == null)
            throw new ArgumentNullException(nameof(clients));
        var random = new Random();
        var availableCurrencies = new List<Currency>
        {
            new Currency { Name = "Dollar", Code = CurrencyCode.Usd },
            new Currency { Name = "Euro", Code = CurrencyCode.Eur },
            new Currency { Name = "Rub", Code = CurrencyCode.Rub }
        };
        return clients.ToDictionary(client => client, c =>
        {
            var accountCount = random.Next(1, 3);
            var accounts = new List<Account>();
            for (var i = 0; i < accountCount; i++)
            {
                var randomCurrency = availableCurrencies[random.Next(availableCurrencies.Count)];
                accounts.Add(new Account
                {
                    Currency = randomCurrency,
                    Amount = random.Next(100, 1000) * 100m
                });
            }

            return accounts;
        });
    }
}