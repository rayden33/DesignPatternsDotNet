namespace Structural.Adapter
{
    public class PhoneInputInterfaceService
    {
        private IPhoneInputInterface _btnInput; 
        public PhoneInputInterfaceService(string inputInterfaceName)
        {
            ChangeInputInterface(inputInterfaceName);
        }
        public void ChangeInputInterface(string inputInterfaceName)
        {
            switch (inputInterfaceName.ToLower())
            {
                case "button": 
                    _btnInput = new ButtonInputInterface();
                    break;
                case "sensor": 
                    SensorDisplayInputInterface sensorInput = new SensorDisplayInputInterface();
                    _btnInput = new SensorToButtonInputAdapter(sensorInput);
                    break;
                default: throw new UndefinedInputInterfaceException();
            }
        }
        public string VirtualPhoneClickAllButton() 
        {
            return _btnInput.ClickLeftButton() + _btnInput.ClickRightButton();
        }
    }
}
