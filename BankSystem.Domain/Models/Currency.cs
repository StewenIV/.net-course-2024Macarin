using System.Diagnostics;

namespace BankSystem.Dom.Models;

public struct Currency
{
    public string Name { get; set; }
    public CurrencyCode Code { get; set; }
}

public enum CurrencyCode
{
    Usd = 0,
    Eur = 1,
    Rub = 2,
}