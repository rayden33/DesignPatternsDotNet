namespace Structural.Adapter
{
    public class SensorToButtonInputAdapter : IPhoneInputInterface
    {
        private readonly SensorDisplayInputInterface _sensorInput;
        public SensorToButtonInputAdapter(SensorDisplayInputInterface sensorInput)
        {
            _sensorInput = sensorInput;
        }

        public string ClickLeftButton() => $"Clicked left button with speed {this._sensorInput.SwipeToLeft()}";
        public string ClickRightButton() => $"Clicked right button with speed {this._sensorInput.SwipeToRight()}";
    }
}