namespace Structural.Facade
{
    public class GameCreatorFacade
    {
        public string CreateRandomGameDescription(string playerName)
        {
            Random random = new Random();
            Weapon weapon = new Weapon("Gun",random.Next(1,10000));
            Player player= new Player(playerName,weapon);
            SceneManager sceneManager = new SceneManager();
            GameManager gameManager = new GameManager(player,sceneManager.GenerateSceneForPlayer(player));
            return gameManager.GenerateGameDescription();
        }
    }
}