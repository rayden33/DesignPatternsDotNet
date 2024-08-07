namespace Structural.Adapter
{
    public class ButtonInputInterface : IPhoneInputInterface
    {
        public string ClickLeftButton() => "Clicked left button";

        public string ClickRightButton() => "Clicked right button";
        
    }
}
