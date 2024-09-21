using System.Diagnostics;

namespace BankSystem.Dom.Models;

public struct Currency(decimal totalAmount, CurrencyCode code)
{
    private const decimal EurToPmrrub = 18.1m;
    private const decimal UsdToPmrrub = 16.3m;
    private const decimal RubToPmrrub = 0.17m;
    public decimal TotalAmount { get; set; } = totalAmount;
    public CurrencyCode Code { get; set; } = code;
    public decimal ExchangeRate
    {
        get
        {
            switch (Code)
            {
                case CurrencyCode.Usd:
                    return TotalAmount * UsdToPmrrub;
                case CurrencyCode.Eur:
                    return TotalAmount * EurToPmrrub;
                case CurrencyCode.Rub:
                    return TotalAmount * RubToPmrrub;
                default:
                    return 0;
            }
        }
    }
}

public enum CurrencyCode
{
    Usd = 0,
    Eur = 1,
    Rub = 2,
}