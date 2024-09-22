using BankSystem.App.Services;
using BankSystem.Dom.Models;

namespace Practice;

class Program
{
    static void Main()
    {
        var employeePasha = new Employee("Pasha", "Ivanov", "aslda@gmail.com", "123456789", 25, "Tiraspol",
            "Developer", new Currency() { TotalAmount = 500m, Code = CurrencyCode.Usd }, DateTime.Now.AddYears(1));
        var employeeSasha = new Employee("Sasha", "Macarin", "copyemail@mgamil.com", "123456789", 20, "Bender",
            "Developer", new Currency() { TotalAmount = 500m, Code = CurrencyCode.Usd }, DateTime.Now.AddYears(1));
        Console.WriteLine("До изменения: " + employeeSasha.Contract);
        UpdateContract(employeeSasha);
        Console.WriteLine("После изменения: " + employeeSasha.Contract);

        Currency currency = new Currency(500m, CurrencyCode.Usd);
        Console.WriteLine(
            $"До изменения: \nCurrency: {currency.Code} {currency.TotalAmount} (PMRRUB: {currency.ExchangeRate})");
        currency = UpdateCurrency(currency);
        Console.WriteLine(
            $"После изменения: \nCurrency : {currency.Code} {currency.TotalAmount} (PMRRUB: {currency.ExchangeRate})");

        Console.WriteLine($"Salary bank owners: PMRRUB " + BankService.GetSalary(new Currency(1000m, CurrencyCode.Eur),
            new Currency(500m, CurrencyCode.Usd),
            [employeePasha, employeeSasha]));
        var clientIvan = new Client("Ivan", "Ivanov", "akjsd@gmail.com", "123456789", 25, "Tiraspol", 1, 1000m);
        Console.WriteLine(
            $"Client: {clientIvan.Name} {clientIvan.Surname} {clientIvan.Email} {clientIvan.PhoneNumber}");
        var employeeAnonymous = BankService.Hiring(clientIvan);
        Console.WriteLine(
            $"Employee: {employeeAnonymous.Contract}");
    }

    private static void UpdateContract(Employee employee)
    {
        employee.StartDate = employee.EndDate;
        employee.EndDate = employee.EndDate.AddYears(1);
        string contract =
            $"Contract for {employee.Name} {employee.Surname} from {employee.StartDate.ToString("d")} to {employee.EndDate.ToString("d")}" +
            $" with salary: {employee.Currency.Code} {employee.Currency.TotalAmount} (PMRRUB: {employee.Currency.ExchangeRate}) has been updated.";
        employee.Contract = contract; //достаточно присвоить новое значение свойству, так как это ссылочный тип данных
    }

    private static Currency UpdateCurrency(Currency currency)
    {
        currency = new Currency(1000m, CurrencyCode.Usd);
        return
            currency; //Чтобы обновить значение экземпляра структуры, нужно вернуть новое значение, так как это значимый тип данных
    }
}