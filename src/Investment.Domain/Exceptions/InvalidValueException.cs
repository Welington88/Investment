namespace Investment.Domain.Exceptions;

public class InvalidValueException : ArgumentException
{
    public InvalidValueException (string message) : base(message) { }
}