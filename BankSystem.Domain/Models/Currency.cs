using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace BankSystem.Dom.Models;

public struct Currency
{
    [Required(ErrorMessage = "Currency name is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Currency code is required")]
    public CurrencyCode Code { get; set; }
    public override bool Equals(object obj)
    {
        if (obj is Currency otherCurrency)
        {
            return Name == otherCurrency.Name && Code == otherCurrency.Code;
        }

        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Code);
    }
}

public enum CurrencyCode
{
    Usd = 0,
    Eur = 1,
    Rub = 2,
}