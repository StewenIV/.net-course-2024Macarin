using BankSystem.Dom.Models;
using Bogus;
using Person = BankSystem.Dom.Models.Person;

namespace BankSystem.App.Services;

public class TestDataGenerator
{
    public static List<Client> GenerateClients()
    {
        var orderNumber = 0;
        var personFaker = new Faker<Client>()
            .RuleFor(p => p.Name, f => f.Name.FirstName())
            .RuleFor(p => p.Surname, f => f.Name.LastName())
            .RuleFor(p => p.Email, f => f.Internet.Email())
            .RuleFor(p => p.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(p => p.Age, f => f.Random.Number(10, 65))
            .RuleFor(p => p.Address, f => f.Address.FullAddress())
            .RuleFor(p => p.OrderNumber, f => ++orderNumber)
            .RuleFor(p => p.OrderAmount, f => f.Random.Int(5, 10) * 100m);
        return personFaker.Generate(1000);
    }

    public static Dictionary<string, Client> GenerateClientsDictionary(List<Client> clients)
    {
        if (clients == null)
            throw new ArgumentNullException(nameof(clients));
        return clients.ToDictionary(c => c.PhoneNumber, c => c);
    }

    public static List<Employee> GenerateEmployees()
    {
        var nameCurrency = new List<string>()
        {
            "Dollar",
            "Euro",
            "Rub",
        };
        var personFaker = new Faker<Employee>()
            .RuleFor(p => p.Name, f => f.Name.FirstName())
            .RuleFor(p => p.Surname, f => f.Name.LastName())
            .RuleFor(p => p.Email, f => f.Internet.Email())
            .RuleFor(p => p.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(p => p.Age, f => f.Random.Number(10, 65))
            .RuleFor(p => p.Address, f => f.Address.FullAddress())
            .RuleFor(p => p.Position, f => f.Name.JobTitle())
            .RuleFor(p => p.Currency, f => new Currency
            {
                Name = f.PickRandom(nameCurrency),
                Code = CurrencyCode.Usd
            })
            .RuleFor(p => p.Salary, f => f.Random.Int(5, 20) * 100m)
            .RuleFor(p => p.StartDate, f => f.Date.Past(1))
            .RuleFor(p => p.EndDate, f => f.Date.Future())
            .RuleFor(p => p.Contract, f => f.Lorem.Sentence());
        return personFaker.Generate(1000);
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