namespace Structural.Facade
{
    public class Player
    {
        public string Name {get; private set;}
        public Weapon RightWeapon {get; private set;}
        public Player(string name, Weapon rightWeapon)
        {
            Name = name;
            RightWeapon = rightWeapon;
        }
    }
}