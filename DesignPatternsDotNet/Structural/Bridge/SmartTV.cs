namespace Structural.Bridge
{
    public class SmartTV : IRemoteControllable
    {
        public bool IsActive = false;
        public string TurnOn()
        {
            IsActive = true;
            return "Smart TV activated";
        }

        public string TurnOff()
        {
            IsActive = false;
            return "Smart TV is disabled";
        }
    }
}