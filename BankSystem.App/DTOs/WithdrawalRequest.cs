namespace BankSystem.Appl.DTOs;

public class WithdrawalRequest
{
    public Guid ClientId { get; set; }
    public decimal Amount { get; set; }
}