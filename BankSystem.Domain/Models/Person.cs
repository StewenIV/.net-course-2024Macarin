namespace BankSystem.Dom.Models;

public class Person(string name, string surname, string email, string phoneNumber, int age, string address)
{
    public string Name { get; set; } = name;
    public string Surname { get; set; } = surname;
    public string PhoneNumber { get; set; } = phoneNumber;
    public string Email { get; set; } = email;
    public int Age { get; set; } = age;
    public string Address { get; set; } = address;
}