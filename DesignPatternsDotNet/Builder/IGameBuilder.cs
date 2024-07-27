public interface IGameBuilder
{
    public void AddFlightProperties(int flightSpeed);
    public void AddSwimmingProperties(int swimmingSpeed);
    public void AddEnemies(int playerAttackDamage);
}