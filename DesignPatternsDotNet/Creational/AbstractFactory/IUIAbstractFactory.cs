namespace Creational.AbstractFactory
{
    public interface IUIAbstractFactory
    {
        public IAbstractButton CreateButton();
        public IAbstractCheckbox CreateCheckbox();
        public IAbstractSlider CreateSlider();
    }
}