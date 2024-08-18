namespace Structural.Decorator
{
    public class NotifierService
    {
        private readonly Notifier _Notifier;

        public NotifierService(Notifier notifier)
        {
            _Notifier = notifier;
        }

        public string NotifyClient(string message) => _Notifier.Notify(message);
    }
}