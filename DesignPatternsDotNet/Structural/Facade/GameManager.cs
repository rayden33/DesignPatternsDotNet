namespace Structural.Facade
{
    public class GameManager
    {
        public Player MainPlayer {get; private set;}
        public string SceneSeed {get; private set;}

        public GameManager(Player player, string sceneSeed)
        {
            MainPlayer = player;
            SceneSeed = sceneSeed;
        }

        public string GenerateGameDescription() => $"Welcome to CustomGame. Difficult level:[{SceneSeed}]. Main hero name is {MainPlayer.Name}. He has right weapon with name is {MainPlayer.RightWeapon.Name} and damage is {MainPlayer.RightWeapon.Damage}";
    }
}
