namespace Creational.AbstractFactory
{
    public class UIService
    {
        private readonly IUIAbstractFactory _uiFactory;
        private readonly IAbstractButton _button;
        private readonly IAbstractCheckbox _checkbox;
        private readonly IAbstractSlider _slider;
        public UIService(string platform)
        {
            platform = platform.ToLower();
            switch(platform)
            {
                case "android": _uiFactory = new AndroidUIFactory(); break;
                case "web": _uiFactory = new WebUIFactory(); break;
                default: throw new UndefinedPlatfromException($"Undefined platform[{platform}]");
            }

            _button = _uiFactory.CreateButton();
            _checkbox = _uiFactory.CreateCheckbox();
            _slider = _uiFactory.CreateSlider();
        }

        public string OnClickButton()
        {
            return _button.OnClick();
        }

        public string MarkCheckbox()
        {
            return _checkbox.Mark();
        }
        
        public string HoldOnCheckBox()
        {
            return _checkbox.HoldOn();
        }

        public string SlideSlider()
        {
            return _slider.Slide();
        }
    }
}