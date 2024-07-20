public class CardService
{
    

    public decimal GetCardBalanceByCardPan(string cardPan)
    {
        string cardBin = cardPan.Substring(0,4);
        CardCreator cc;
        switch(cardBin)
        {
            case "9860":
            case "4187": cc = new HumoCardCreator();
                break;
            case "8600":
            case "5614": cc = new UzcardCardCreator();
                break;
            default: throw new Exception("Not supported card");
        }

        return cc.GetCardBalance(cardPan);
    }
}