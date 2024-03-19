namespace apbd3;

public class OverfillExcetion : Exception
{
    public OverfillExcetion()
    {
    }

    public OverfillExcetion(string? message) : base(message)
    {
    }

    public OverfillExcetion(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}