using Structural.Decorator;

public class DecoratorTests
{
    [Fact]
    public void CheckNotificationWithAll()
    {
        SmsNotifier smsNotifier= new SmsNotifier();
        EmailNotifierDecorator emailNotifierDecorator= new EmailNotifierDecorator(smsNotifier);
        FacebookNotifierDecorator facebookNotifierDecorator= new FacebookNotifierDecorator(emailNotifierDecorator);
        var service = new NotifierService(facebookNotifierDecorator);

        Assert.True(service.NotifyClient("hello")=="Notify with SMS [hello] and with Email and with Facebook");

    }
}