using Creational.Singleton;
public class DatabaseServiceTests
{
    [Fact]
    public void CreateMoreConnections()
    {
        DatabaseService databaseService = new DatabaseService();
        databaseService.CreateNewConnection();
        int firstConnectionSessionId = databaseService.GetConnectionSessionId();
        databaseService.CreateNewConnection();
        int secondConnectionSessionId = databaseService.GetConnectionSessionId();
        Assert.True(firstConnectionSessionId == secondConnectionSessionId);
    }

    [Fact]
    public void UseConnectionBeforeCreate()
    {
        DatabaseService databaseService = new DatabaseService();
        Assert.Throws<ConnectionIsNotCreatedException>(() => databaseService.GetConnectionSessionId());
    }

    
}