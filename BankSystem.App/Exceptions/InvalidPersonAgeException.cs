namespace BankSystem.Appl.Exceptions;

public class InvalidPersonAgeException : Exception
{
    public InvalidPersonAgeException(string message) : base(message)
    {
        
    }
}