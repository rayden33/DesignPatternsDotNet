public class DatabaseService
{
    private Database _database;
    public void CreateNewConnection()
    {
        _database = Database.GetInstance();
    }
    public int GetConnectionSessionId()
    {
        if(_database == null)
            throw new ConnectionIsNotCreatedException("Please first create connection");
        return _database.DatabaseSessionId;
    }
}