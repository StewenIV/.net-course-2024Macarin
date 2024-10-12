using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.VisualBasic;

namespace BankSystem.Dom.Models;

public class Employee : Person
{
    [Required(ErrorMessage = "Position is required")]
    [MaxLength(50, ErrorMessage = "Position must be less than 50 characters")]
    public string Position { get; set; }
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; } = DateTime.Now;
    [DataType(DataType.Date)]
    public DateTime EndDate { get; set; }
    [Required(ErrorMessage = "Salary is required")]
    public decimal Salary { get; set; }
    public Currency Currency { get; set; }

    public string Contract
    {
        get
        {
            return
                $"Contract for {Name} {Surname} from {StartDate.ToString("d")} to {EndDate.ToString("d")} with salary: {Salary} {Currency.Code}";
        }
        set { }
    }

    public override bool Equals(object obj)
    {
        if (obj is Employee otherEmployee)
        {
            return Name == otherEmployee.Name && Surname == otherEmployee.Surname &&
                   PhoneNumber == otherEmployee.PhoneNumber &&
                   Email == otherEmployee.Email && Age == otherEmployee.Age && Address == otherEmployee.Address &&
                   Position == otherEmployee.Position && StartDate == otherEmployee.StartDate &&
                   EndDate == otherEmployee.EndDate &&
                   Salary == otherEmployee.Salary && Currency.Equals(otherEmployee.Currency);
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(
            HashCode.Combine(Name, Surname, PhoneNumber, Email),
            HashCode.Combine(Age, Address, Position, Salary),
            Currency.GetHashCode(), StartDate, EndDate
        );
    }
}