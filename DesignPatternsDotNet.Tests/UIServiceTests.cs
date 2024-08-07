using Creational.AbstractFactory;
namespace DesignPatternsDotNet.Tests;


public class UIServiceTests
{
    [Fact]
    public void AndroidButton()
    {
        var uiService = new UIService("android");
        string onClickResponse = uiService.OnClickButton();
        Assert.True(onClickResponse == "Clicked Android button");
    }

    [Fact]
    public void AndroidCheckbox()
    {
        var uiService = new UIService("android");
        string markResponse = uiService.MarkCheckbox();
        string holdOnResponse = uiService.HoldOnCheckBox();
        Assert.True(markResponse == "Android checkbox marked" && holdOnResponse == "Android checkbox hold on");
    }

    [Fact]
    public void AndroidSlider()
    {
        var uiService = new UIService("android");
        string slideResponse = uiService.SlideSlider();
        Assert.True(slideResponse == "Android sliding...");
    }

    [Fact]
    public void WebButton()
    {
        var uiService = new UIService("web");
        string onClickResponse = uiService.OnClickButton();
        Assert.True(onClickResponse == "Clicked Web button");
    }

    [Fact]
    public void WebCheckbox()
    {
        var uiService = new UIService("web");
        string markResponse = uiService.MarkCheckbox();
        string holdOnResponse = uiService.HoldOnCheckBox();
        Assert.True(markResponse == "Web checkbox marked" && holdOnResponse == "Web checkbox hold on");
    }

    [Fact]
    public void WebSlider()
    {
        var uiService = new UIService("web");
        Assert.Throws<NotImplementedException>(()=> uiService.SlideSlider());
        /// TO DO waiting implementation
        //string slideResponse = uiService.SlideSlider();
        //Assert.True(slideResponse == "Web sliding...");
    }

    

    [Theory]
    [InlineData("ios")]
    [InlineData("androider")]
    [InlineData("")]
    public void UndefinedPlatform(string platform)
    {
        Assert.Throws<UndefinedPlatfromException>(() => {UIService uiService = new UIService(platform);});
    }
}