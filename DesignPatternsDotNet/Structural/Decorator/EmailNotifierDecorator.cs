namespace Structural.Decorator
{
    public class EmailNotifierDecorator : NotifierDecorator
    {
        public EmailNotifierDecorator(Notifier wrapped) : base(wrapped)
        {}

        public override string Notify(string message) => $"{base.Notify(message)} and with Email";
    }
}
