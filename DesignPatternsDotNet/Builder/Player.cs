public class Player
{

    public int FlyingSpeed {get; private set;} = 0;
    public int SwimmingSpeed {get; private set;} = 0;
    public int AttackDamage {get; private set;} = 0;

    public void AddFlyingSpeed (int flyingSpeed) => FlyingSpeed = flyingSpeed;
    public void AddSwimmingSpeed(int swimmingSpeed) => SwimmingSpeed = swimmingSpeed;
    public void AddAttackDamage(int attackDamage) => AttackDamage = attackDamage;

    
}