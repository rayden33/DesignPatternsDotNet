namespace DesignPatternsDotNet.Tests;

public class CardServiceTests
{
    [Fact]
    public void GetHumoCardBalance()
    {
        var cardService = new CardService();
        decimal cardBalance = cardService.GetCardBalanceByCardPan("9860**********01");
        Assert.True(cardBalance > 0);
    }

    [Fact]
    public void GetUzcardCardBalance()
    {
        var cardService = new CardService();
        decimal cardBalance = cardService.GetCardBalanceByCardPan("8600**********01");
        Assert.True(cardBalance > 0);
    }
}