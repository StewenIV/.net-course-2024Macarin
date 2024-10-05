using System.ComponentModel.DataAnnotations;

namespace BankSystem.Dom.Models;

public class Account
{
    [Required(ErrorMessage = "Currency is required")]
    public Currency Currency { get; set; }

    [Required(ErrorMessage = "Amount is required")]
    public decimal Amount { get; set; }
}