namespace Creational.FactoryMethod
{
    public abstract class CardCreator
    {
        public abstract ICard FactoryMethod(string cardPan);

        public decimal GetCardBalance(string cardPan)
        {
            ICard card = FactoryMethod(cardPan);
            Console.WriteLine(card.GetType());

            return card.GetBalance();
        }
    }
}