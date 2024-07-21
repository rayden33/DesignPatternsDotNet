public class CardService
{
    

    public decimal GetCardBalanceByCardPan(string cardPan)
    {
        string cardBin = cardPan.Substring(0,4);
        CardCreator cc;
        switch(cardBin)
        {
            case "9860":
            case "4187": 
                cc = new HumoCardCreator();
                break;
            case "8600":
            case "5614": 
                cc = new UzcardCardCreator();
                break;
            // We can add any ICard creator in future.
            /*case "4790":
                cc = new VisaCardCreator();
                break;*/
            default: 
                throw new UndefinedCardException("Not supported card");
        }

        return cc.GetCardBalance(cardPan);
    }
}