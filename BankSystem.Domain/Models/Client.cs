namespace BankSystem.Dom.Models;

public class Client(
    string name,
    string surname,
    string email,
    string phoneNumber,
    int age,
    string address,
    int orderNumber,
    decimal orderAmount) : Person(name, surname, email, phoneNumber, age, address)
{
    public int OrderNumber { get; set; } = orderNumber;
    public decimal OrderAmount { get; set; } = orderAmount;
}