namespace BankSystem.Dom.Models;

public class Client : Person
{
    public int OrderNumber { get; set; }
    public decimal OrderAmount { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Client otherClient)
        {
            return Name == otherClient.Name && Surname == otherClient.Surname && PhoneNumber == otherClient.PhoneNumber &&
                   Email == otherClient.Email && Age == otherClient.Age && Address == otherClient.Address &&
                   OrderNumber == otherClient.OrderNumber && OrderAmount == otherClient.OrderAmount;
        }

        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Surname, PhoneNumber, Email, Age, Address, OrderNumber, OrderAmount);
    } 
}