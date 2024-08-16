namespace Structural.Bridge
{
    public class SmartHomeService
    {
        private readonly SmartTV _smartTV;
        private readonly AirConditioner _airConditioner;

        public SmartHomeService()
        {
            _smartTV = new SmartTV();
            _airConditioner = new AirConditioner();
        }
        public void WakeUp()
        {
            UniversalRemoteController remoteTV = new UniversalRemoteController(_smartTV);
            remoteTV.PowerOn();

            UniversalRemoteController remoteAir = new UniversalRemoteController(_airConditioner);
            remoteAir.PowerOn();
        }
        public string PreparingHome()
        {
            AdvancedRemoteController remote = new AdvancedRemoteController(_airConditioner);
            return remote.PowerOnWithTimer(900);
        }

        public SmartTV GetSmartTV() => _smartTV;
        public AirConditioner GetAirConditioner() => _airConditioner;
    }
}