using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BankSystem.Dom.Models;

public class Account
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Currency name is required")]
    [MinLength(5, ErrorMessage = "Currency name should be at least 5 characters")]
    public string CurrencyName { get; set; }

    [Required(ErrorMessage = "Currency is required")]
    public Currency Currency { get; set; }

    [Required(ErrorMessage = "Amount is required")]
    public decimal Amount { get; set; }

    public Guid ClientId { get; set; }
    public Client? Client { get; set; }
}