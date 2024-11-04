using BankSystem.Dom.Models;

namespace BankSystem.Appl.DTOs;

public class ClientDto
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string PassportDetails { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal? Bonus { get; set; }
    public int OrderNumber { get; set; }
    public decimal OrderAmount { get; set; }
}