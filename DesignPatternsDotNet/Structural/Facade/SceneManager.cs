namespace Structural.Facade
{
    public class SceneManager
    {
        
        public string GenerateSceneForPlayer(Player player)
        {
            if(player.RightWeapon.Damage <= 0)
                return "Peaceful";
            else if(player.RightWeapon.Damage < 10)
                return "Easy";
            else if (player.RightWeapon.Damage < 100)
                return "Normal";
            else
                return "Hard";
        }
    }
}
