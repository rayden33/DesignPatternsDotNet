public class ConnectionIsNotCreatedException : Exception
{
    public ConnectionIsNotCreatedException()
    {
    }

    public ConnectionIsNotCreatedException(string message) 
        : base(message)
    {
    }
    public ConnectionIsNotCreatedException(string message, Exception inner) 
        : base(message, inner)
    {
    }
}