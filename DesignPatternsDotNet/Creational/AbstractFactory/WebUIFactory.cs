namespace Creational.AbstractFactory
{
    public class WebUIFactory : IUIAbstractFactory
    {
        public IAbstractButton CreateButton()
        {
            return new WebButton();
        }

        public IAbstractCheckbox CreateCheckbox()
        {
            return new WebCheckbox();
        }

        public IAbstractSlider CreateSlider()
        {
            return new WebSlider();
        }
    }
}