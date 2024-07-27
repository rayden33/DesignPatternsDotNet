public class UndefinedGameTypeException : Exception
{
    public UndefinedGameTypeException()
    {
    }

    public UndefinedGameTypeException(string message) 
        : base(message)
    {
    }
    public UndefinedGameTypeException(string message, Exception inner) 
        : base(message, inner)
    {
    }
}