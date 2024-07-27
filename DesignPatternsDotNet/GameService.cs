using System.Text;

public class GameService
{
    public string WorldDescri {get; private set;}
    public Player WorldPlayer {get; private set;}
    
    public void CreateNewGame(string gameType)
    {
        PlayerBuilder playerBuilder= new PlayerBuilder();
        WorldBuilder worldBuilder= new WorldBuilder();
        GameDirector gameDirector = new GameDirector();
        switch(gameType)
        {
            case "undersea": 
                gameDirector.CreateUnderseaGame(playerBuilder);
                gameDirector.CreateUnderseaGame(worldBuilder);
                break;
            case "openworld":
                gameDirector.CreateOpenWorldGame(playerBuilder);
                gameDirector.CreateOpenWorldGame(worldBuilder);
                break;
            default: throw new UndefinedGameTypeException($"Undefined game type [{gameType}]");
        }

        WorldDescri = worldBuilder.GetWorldDescription();
        WorldPlayer = playerBuilder.GetPlayer();

    }

    public string DescribeTheGame()
    {
        StringBuilder gameDescription = new StringBuilder();

        gameDescription.AppendLine("WELCOME");

        /// World description part
        gameDescription.Append('-',30);
        gameDescription.AppendLine();
        gameDescription.AppendLine("WORLD DESCRIPTION:");
        gameDescription.Append(WorldDescri);

        /// Player characteristics part
        gameDescription.Append('-',30);
        gameDescription.AppendLine();
        gameDescription.AppendLine($"Player flight speed: [{WorldPlayer.FlyingSpeed}]");
        gameDescription.AppendLine($"Player swimming speed: [{WorldPlayer.SwimmingSpeed}]");
        gameDescription.AppendLine($"Player attack damage: [{WorldPlayer.AttackDamage}]");

        return gameDescription.ToString();
    }
}