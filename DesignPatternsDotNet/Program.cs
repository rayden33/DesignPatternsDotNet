// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please select pattern:");
string pattern = Console.ReadLine();

switch(pattern)
{
    case "Factory Method": FactoryMethod();
        break;
    default: throw new Exception("Undefined pattern");
}


void FactoryMethod()
{
    Console.WriteLine("Please insert card pan:");
    string cardPan = Console.ReadLine();
    CardService cardService = new CardService();
    Console.WriteLine(cardService.GetCardBalanceByCardPan(cardPan));
}

