using Structural.Adapter;
namespace DesignPatternsDotNet.Tests;


public class PhoneInputInterfaceServiceTests
{

    [Fact]
    public void PhoneInputClickImitation()
    {
        var buttonPhoneInputService = new PhoneInputInterfaceService("button");
        var sensorPhoneInputService = new PhoneInputInterfaceService("sensor");
        Assert.True(buttonPhoneInputService.VirtualPhoneClickAllButton() == "Clicked left buttonClicked right button" 
        && sensorPhoneInputService.VirtualPhoneClickAllButton() == "Clicked left button with speed -1Clicked right button with speed 1");
    }

    [Theory]
    [InlineData("sound")]
    [InlineData("mental")]
    [InlineData("")]
    public void UndefinedPlatform(string inputInterface)
    {
        Assert.Throws<UndefinedInputInterfaceException>(() => {var buttonPhoneInputService = new PhoneInputInterfaceService(inputInterface);});
    }
}