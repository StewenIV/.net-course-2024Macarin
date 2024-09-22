using BankSystem.App.Services;
using BankSystem.Dom.Models;

namespace Practice;

class Program
{
    static void Main()
    {
        var employeePasha = new Employee
        {
            Name = "Pasha",
            Surname = "Ivanov",
            Email = "aslda@gmail.com",
            PhoneNumber = "123456789",
            Age = 25,
            Address = "Tiraspol",
            Position = "Developer",
            Salary = 1000m,
            Currency = new Currency { Name = "Dollar", Code = CurrencyCode.Usd },
            EndDate = DateTime.Now.AddYears(1)
        };
        var employeeSasha = new Employee
        {
            Name = "Sasha",
            Surname = "Macarin",
            Email = "copyemail@mgamil.com",
            PhoneNumber = "123456789",
            Age = 20,
            Address = "Bender",
            Position = "Developer",
            Salary = 1000m,
            Currency = new Currency { Name = "Dollar", Code = CurrencyCode.Usd },
            EndDate = DateTime.Now.AddYears(1)
        };
        Console.WriteLine("До изменения: " + employeeSasha.Contract);
        UpdateContract(employeeSasha);
        Console.WriteLine("После изменения: " + employeeSasha.Contract);

        Currency currency = new Currency
        {
            Name = "Dollar",
            Code = CurrencyCode.Usd,
        };
        Console.WriteLine(
            $"До изменения: \nCurrency: {currency.Name} {currency.Code}");
        currency = UpdateCurrency(currency);
        Console.WriteLine(
            $"После изменения: \nCurrency : {currency.Name} {currency.Code}");

        Console.WriteLine($"Salary bank owners: " + BankService.GetSalary(1000m, 500m, [employeePasha, employeeSasha]));
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
        Console.WriteLine(
            $"Client: {clientIvan.Name} {clientIvan.Surname} {clientIvan.Email} {clientIvan.PhoneNumber}");
        var employeeAnonymous = BankService.Hiring(clientIvan);
        Console.WriteLine($"Employee: {employeeAnonymous.Contract}");
    }

    private static void UpdateContract(Employee employee)
    {
        employee.StartDate = employee.EndDate;
        employee.EndDate = employee.EndDate.AddYears(1);
        string contract =
            $"Contract for {employee.Name} {employee.Surname} from {employee.StartDate.ToString("d")} to {employee.EndDate.ToString("d")}" +
            $" with salary: with salary: {employee.Salary} {employee.Currency.Code}) has been updated.";
        employee.Contract = contract; //достаточно присвоить новое значение свойству, так как это ссылочный тип данных
    }

    private static Currency UpdateCurrency(Currency currency)
    {
        currency = new Currency
        {
            Code = CurrencyCode.Eur,
            Name = "Euro"
        };
        return
            currency; //Чтобы обновить значение экземпляра структуры, нужно вернуть новое значение, так как это значимый тип данных
    }
}