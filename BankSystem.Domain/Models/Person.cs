using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace BankSystem.Dom.Models;

public class Person
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 50")]
    public string Name { get; set; }

    [StringLength(50, MinimumLength = 5, ErrorMessage = "Surname must be between 5 and 50")]
    public string Surname { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [Phone(ErrorMessage = "Invalid phone number")]
    public string PhoneNumber { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }

    [Range(0, 99, ErrorMessage = "Age must be between 18 and 99")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Address is required")]
    public string Address { get; set; }

    public string PassportDetails { get; set; }

    public DateTime BirthDate => DateTime.Now.AddYears(-Age);

    public decimal Bonus { get; set; } = 0m;
}