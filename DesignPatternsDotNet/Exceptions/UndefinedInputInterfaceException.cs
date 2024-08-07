public class UndefinedInputInterfaceException : Exception
{
    public UndefinedInputInterfaceException()
    {
    }

    public UndefinedInputInterfaceException(string message) 
        : base(message)
    {
    }
    public UndefinedInputInterfaceException(string message, Exception inner) 
        : base(message, inner)
    {
    }
}