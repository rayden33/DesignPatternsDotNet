namespace Structural.Decorator
{
    public class FacebookNotifierDecorator : NotifierDecorator
    {
        public FacebookNotifierDecorator(Notifier wrapped) : base(wrapped)
        {}

        public override string Notify(string message) => $"{base.Notify(message)} and with Facebook";
    }
}
