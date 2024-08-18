namespace Structural.Facade
{
    public class Weapon
    {
        public string Name {get; private set;}
        public int Damage {get; private set;}
        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
}