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
        _balance = rand.Next();
        Console.WriteLine($"Humo balance is:[{_balance}]");
        return _balance;
    }
}