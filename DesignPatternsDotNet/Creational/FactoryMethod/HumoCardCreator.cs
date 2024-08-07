namespace Creational.FactoryMethod
{
    public class HumoCardCreator : CardCreator
    {
        public override ICard FactoryMethod(string cardPan)
        {
            return new HumoCard(cardPan);
        }
    }
}