namespace Creational.FactoryMethod
{
    public class VisaCardCreator : CardCreator
    {
        public override ICard FactoryMethod(string cardPan)
        {
            return new VisaCard(cardPan);
        }
    }
}