public class GameDirector
{

    public void CreateUnderseaGame(IGameBuilder builder)
    {
        builder.AddSwimmingProperties(10);
    }

    public void CreateOpenWorldGame(IGameBuilder builder)
    {
        builder.AddFlightProperties(10);
        builder.AddSwimmingProperties(5);
        builder.AddEnemies(100);
    }

}