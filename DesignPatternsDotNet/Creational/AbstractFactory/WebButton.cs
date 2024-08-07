namespace Creational.AbstractFactory
{
    public class WebButton : IAbstractButton
    {
        public string OnClick()
        {
            return "Clicked Web button";
        }
    }
}