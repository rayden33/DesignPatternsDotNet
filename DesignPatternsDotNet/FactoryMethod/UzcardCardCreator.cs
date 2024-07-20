public class UzcardCardCreator : CardCreator
{
    public override ICard FactoryMethod(string cardPan)
    {
        return new UzcardCard(cardPan);
    }
}