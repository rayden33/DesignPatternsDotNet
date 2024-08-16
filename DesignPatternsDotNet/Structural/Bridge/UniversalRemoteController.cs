namespace Structural.Bridge
{
    public class UniversalRemoteController
    {
        protected readonly IRemoteControllable _device;
        public UniversalRemoteController(IRemoteControllable device)
        {
            _device = device;
        }

        public string PowerOn() => _device.TurnOn();
        public string PowerOff() => _device.TurnOff();
    }
}