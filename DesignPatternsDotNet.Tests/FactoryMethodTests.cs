using Creational.FactoryMethod;

public class FactoryMethodTests
{
    [Fact]
    public void GetHumoCardBalance()
    {
        var cardService = new CardService();
        decimal cardBalance = cardService.GetCardBalanceByCardPan("9860**********01");
        Assert.True(cardBalance > 10000000 && cardBalance < 1000000000);
    }

    [Fact]
    public void GetUzcardCardBalance()
    {
        var cardService = new CardService();
        decimal cardBalance = cardService.GetCardBalanceByCardPan("8600**********01");
        Assert.True(cardBalance > 0);
    }

    [Theory]
    [InlineData("4790**********01")]
    [InlineData("4999**********01")]
    [InlineData("Hello")]
    public void GetUndefinedCardBalance(string cardPan)
    {
        var cardService = new CardService();
        Assert.Throws<UndefinedCardException>(() => Console.WriteLine(cardService.GetCardBalanceByCardPan(cardPan)));
    }
}