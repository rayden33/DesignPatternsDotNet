public class UndefinedPlatfromException : Exception
{
    public UndefinedPlatfromException()
    {
    }

    public UndefinedPlatfromException(string message) 
        : base(message)
    {
    }
    public UndefinedPlatfromException(string message, Exception inner) 
        : base(message, inner)
    {
    }
}