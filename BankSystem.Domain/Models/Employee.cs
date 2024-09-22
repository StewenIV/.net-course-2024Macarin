using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.VisualBasic;

namespace BankSystem.Dom.Models;

public class Employee : Person
{
    public string Position { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; }
    public decimal Salary { get; set; }
    public Currency Currency { get; set; }

    public string Contract
    {
        get
        {
            return
                $"Contract for {Name} {Surname} from {StartDate.ToString("d")} to {EndDate.ToString("d")} with salary: {Salary} {Currency.Code}";
        }
        set
        {
            
        }
    }
}