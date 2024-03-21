namespace apbd3;

public class takeTooMuchException : Exception
{
    public takeTooMuchException()
    {
    }
    public takeTooMuchException(string? message) : base(message)
    {
    }
}