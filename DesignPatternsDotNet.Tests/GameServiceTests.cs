public class GameServiceTests
{
    [Fact]
    public void CreateUnderSeaWorld()
    {
        var gameService = new GameService();
        gameService.CreateNewGame("undersea");
        string description = gameService.DescribeTheGame();
        bool condition = !(description.Contains("wings") || description.Contains("enemies")) && description.Contains("lakes");
        Assert.True(condition);
    }

    [Fact]
    public void CreateOpenWorld()
    {
        var gameService = new GameService();
        gameService.CreateNewGame("openworld");
        string description = gameService.DescribeTheGame();
        bool condition = description.Contains("wings") & description.Contains("enemies") && description.Contains("lakes");
        Assert.True(condition);
    }

    [Theory]
    [InlineData("underseat")]
    [InlineData("open")]
    [InlineData("")]
    public void GetUndefinedGameType(string gameType)
    {
        var gameService = new GameService();
        Assert.Throws<UndefinedGameTypeException>(() => gameService.CreateNewGame(gameType));
    }
}