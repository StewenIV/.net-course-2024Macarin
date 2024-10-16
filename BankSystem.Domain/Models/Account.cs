using System.ComponentModel.DataAnnotations;

namespace BankSystem.Dom.Models;

public class Account
{
    public Guid Id { get; set; }
    public string CurrencyName { get; set; }
    [Required(ErrorMessage = "Currency is required")]
    public Currency Currency { get; set; }

    [Required(ErrorMessage = "Amount is required")]
    public decimal Amount { get; set; }
    public Guid ClientId { get; set; }
    public Client? Client { get; set; }
}