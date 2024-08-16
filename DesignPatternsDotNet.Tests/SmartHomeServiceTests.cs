using Structural.Bridge;
namespace DesignPatternsDotNet.Tests;
public class SmartHomeServiceTests
{
    [Fact]
    public void CheckPreparingHome()
    {
        SmartHomeService smartHomeService = new SmartHomeService();
        Assert.True(smartHomeService.PreparingHome()=="Air Conditioner activated with duration is 900 seconds. ... After 900 seconds. Air Conditioner is disabled"
        && !smartHomeService.GetSmartTV().IsActive && !smartHomeService.GetAirConditioner().IsActive);
    }

    [Fact]
    public void CheckWakeUpFunction()
    {
        SmartHomeService smartHomeService = new SmartHomeService();
        smartHomeService.WakeUp();
        Assert.True(smartHomeService.GetSmartTV().IsActive && smartHomeService.GetAirConditioner().IsActive);
    }
}