namespace Structural.Decorator
{
    public class SmsNotifier : Notifier
    {
        public override string Notify(string message) => $"Notify with SMS [{message}]";
    }
}
