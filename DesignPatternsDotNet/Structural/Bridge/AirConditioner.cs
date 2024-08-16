namespace Structural.Bridge
{
    public class AirConditioner : IRemoteControllable
    {
        public bool IsActive = false;
        public string TurnOn()
        {
            IsActive = true;
            return "Air Conditioner activated";
        }

        public string TurnOff()
        {
            IsActive = false;
            return "Air Conditioner is disabled";
        }
    }
}