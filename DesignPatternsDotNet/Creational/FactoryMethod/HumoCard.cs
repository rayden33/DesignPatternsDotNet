namespace Creational.FactoryMethod
{
    public class HumoCard : ICard
    {
        private string _cardPan;
        private decimal _balance;
        public HumoCard(string cardPan)
        {
            _cardPan = cardPan;
        }
        public decimal GetBalance()
        {
            Random rand = new Random();
            _balance = rand.Next(10000000,1000000000);
            Console.WriteLine($"Humo[{_cardPan}] balance:[{_balance}]");
            return _balance;
        }
    }
}