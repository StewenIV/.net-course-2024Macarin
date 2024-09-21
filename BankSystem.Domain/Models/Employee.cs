using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.VisualBasic;

namespace BankSystem.Dom.Models;

public class Employee: Person
{
    public string Position { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; } 
    public string Contract { get; set; } 
    public Currency Currency { get; set; } 
    public Employee(string name, string surname, string email, string phoneNumber, int age, string address, string position, Currency currency,  DateTime endDate, DateTime startDate = default)
        : base(name, surname, email, phoneNumber, age, address)
    {
        Position = position;
        StartDate =  startDate == default ? DateTime.Now : startDate;;
        EndDate = endDate;
        Contract = $"Contract for {name} {surname} from {StartDate.ToString("d")} to {EndDate.ToString("d")} with salary: {currency.Code} {currency.TotalAmount} (PMRRUB: {currency.ExchangeRate})";
        Currency = currency;
    }
}