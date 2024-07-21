public class UndefinedCardException : Exception
{
    public UndefinedCardException()
    {
    }

    public UndefinedCardException(string message) 
        : base(message)
    {
    }
    public UndefinedCardException(string message, Exception inner) 
        : base(message, inner)
    {
    }
}