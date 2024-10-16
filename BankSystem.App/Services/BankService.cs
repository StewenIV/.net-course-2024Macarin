using BankSystem.Dom.Models;

namespace BankSystem.App.Services;

public class BankService
{
    private List<Person> _blackList = new();
    public static int GetSalary(decimal bankProfit, decimal bankExpenses, Employee[] owners)
    {
        if (owners == null || owners.Length == 0)
        {
            throw new ArgumentNullException(nameof(owners));
        }

        decimal netProfit = bankProfit - bankExpenses;
        if (netProfit < 0)
        {
            throw new InvalidOperationException("Bank is in debt");
        }

        decimal salary = netProfit / owners.Length;
        return (int)salary;
    }

    public static Employee Hiring(Client client)
    {
        if (client == null)
        {
            throw new ArgumentNullException(nameof(client), "Client is null");
        }

        return new Employee
        {
            Name = client.Name,
            Surname = client.Surname,
            Email = client.Email,
            PhoneNumber = client.PhoneNumber,
            BirthDate = client.BirthDate,
            Address = client.Address,
            Position = "Client Manager",
            Salary = 1000m,
            EndDate = DateTime.Now.AddYears(1)
        };
    }

    public void AddBonus<T>(T person) where T : Person
    {
        if (person == null)
        {
            throw new ArgumentNullException(nameof(person));
        }

        decimal bonus;
        if (person.Bonus == 0m)
        {
            bonus = 100m;
            person.Bonus += bonus;
        }
        else
        {
            person.Bonus *= 2m;
        }
    }
    
    public void AddToBlackList<T>(T person) where T : Person
    {
        if (person == null)
        {
            throw new ArgumentNullException(nameof(person));
        }
        _blackList.Add(person);
    }
    
    public bool IsPersonInBlackList<T>(T person) where T : Person
    {
        if (person == null)
        {
            throw new ArgumentNullException(nameof(person));
        }
        return _blackList.Contains(person);
    }
}