public class Database
{
    private static Database _instance = null;
    private static readonly object _lock = new object();
    public int DatabaseSessionId {get; set;}
    private Database()
    {
        Random rand = new Random();
        DatabaseSessionId = rand.Next();
    }

    public static Database GetInstance()
    {
        if(_instance == null)
        {
            lock(_lock)
            {
                if(_instance == null)
                {
                    _instance = new Database();
                }
            }
        }

        return _instance;
    }
}