public class WorldBuilder : IGameBuilder
{
    private WorldDescription _world;
    public WorldBuilder()
    {
        this.Reset();
    }
    public void AddEnemies(int playerAttackDamage) => _world.AddEnemy();
    public void AddFlightProperties(int flightSpeed) => _world.AddWings();
    public void AddSwimmingProperties(int swimmingSpeed) => _world.AddLakes();

    public void Reset() => _world = new WorldDescription();

    public string GetWorldDescription()
    {
        string result = _world.GetWorldDescription();
        _world = new WorldDescription();
        return result;
    }
}