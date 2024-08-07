namespace Creational.Builder
{
    public class PlayerBuilder : IGameBuilder
    {
        private Player _player = new Player();

        public PlayerBuilder()
        {
            this.Reset();
        }
        public void AddFlightProperties(int flightSpeed) => _player.AddFlyingSpeed(flightSpeed);
        public void AddSwimmingProperties(int swimmingSpeed) => _player.AddSwimmingSpeed(swimmingSpeed);
        public void AddEnemies(int playerAttackDamage) => _player.AddAttackDamage(playerAttackDamage);

        public void Reset() => _player = new Player();
        

        public Player GetPlayer()
        {
            Player result = _player;
            _player = new Player();
            return result;
        }

    }
}