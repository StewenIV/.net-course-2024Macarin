using BankSystem.Dom.Models;

namespace BankSystem.App.Services;

public class BankService
{
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
            Age = client.Age,
            Address = client.Address,
            Position = "Client Manager",
            Salary = 1000m,
            Currency = new Currency
            {
                Name = "Dollar",
                Code = CurrencyCode.Usd,
            },
            EndDate = DateTime.Now.AddYears(1)
        };
    }
}