namespace Creational.AbstractFactory
{
    public class AndroidUIFactory : IUIAbstractFactory
    {
        public IAbstractButton CreateButton()
        {
            return new AndroidButton();
        }

        public IAbstractCheckbox CreateCheckbox()
        {
            return new AndroidCheckbox();
        }

        public IAbstractSlider CreateSlider()
        {
            return new AndroidSlider();
        }
    }
}