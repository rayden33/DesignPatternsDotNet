namespace Creational.FactoryMethod
{
    public class VisaCard : ICard
    {
        private string _cardPan;
        private decimal _balance;
        public VisaCard(string cardPan)
        {
            _cardPan = cardPan;
        }
        public decimal GetBalance()
        {
            Random rand = new Random();
            _balance = rand.Next(100, 1000);
            Console.WriteLine($"Visa[{_cardPan}] balance:[{_balance}]");
            return _balance;
        }
    }
}