namespace Structural.Decorator
{
    public class NotifierDecorator : Notifier
    {
        private readonly Notifier _Wrapped;
        public NotifierDecorator(Notifier wrapped)
        {
            _Wrapped = wrapped;
        }

        public override string Notify(string message) => _Wrapped.Notify(message);
    }
}