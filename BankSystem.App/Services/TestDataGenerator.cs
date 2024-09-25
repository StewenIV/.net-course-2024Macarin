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
            .RuleFor(p => p.OrderAmount, f =>  f.Random.Int(5,10)*100m);
        return personFaker.Generate(1000);
    }

    public static Dictionary<string, Client> GenerateClientsDictionary(List<Client> clients)
    {
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
            .RuleFor(p => p.Salary, f => f.Random.Int(5,20)*100m)
            .RuleFor(p => p.StartDate, f => f.Date.Past(1))
            .RuleFor(p => p.EndDate, f => f.Date.Future())
            .RuleFor(p => p.Contract, f => f.Lorem.Sentence());
        return personFaker.Generate(1000);
    }
}