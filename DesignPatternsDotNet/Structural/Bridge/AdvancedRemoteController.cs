namespace Structural.Bridge
{
    public class AdvancedRemoteController : UniversalRemoteController
    {
        public AdvancedRemoteController(IRemoteControllable device) : base(device)
        {
        }

        public string PowerOnWithTimer(int durationOfActivity) => $"{_device.TurnOn()} with duration is {durationOfActivity} seconds. ... After {durationOfActivity} seconds. {_device.TurnOff()}";
    }
}
