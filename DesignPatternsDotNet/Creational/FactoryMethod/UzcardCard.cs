namespace Creational.FactoryMethod
{
    public class UzcardCard : ICard
    {
        private string _cardPan;
        private decimal _balance;
        public UzcardCard(string cardPan)
        {
            _cardPan = cardPan;
        }

        public decimal GetBalance()
        {
            Random rand = new Random();
            _balance = rand.Next(10000,1000000);
            Console.WriteLine($"Uzcard[{_cardPan}] balance:[{_balance}]");
            return _balance;
        }
    }
}