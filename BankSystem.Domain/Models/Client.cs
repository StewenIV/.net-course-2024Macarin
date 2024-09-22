namespace BankSystem.Dom.Models;

public class Client : Person
{
    public int OrderNumber { get; set; }
    public decimal OrderAmount { get; set; }
}