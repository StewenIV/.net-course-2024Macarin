namespace BankSystem.Appl.Models;

public class CurrencyExchangeResponse
{
    public int Error { get; set; }
    public string Error_message { get; set; }
    public decimal Amount { get; set; }
}