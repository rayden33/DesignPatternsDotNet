// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please select pattern:");
string pattern = Console.ReadLine();

switch(pattern)
{
    case "Factory Method": FactoryMethod();
        break;
    case "Abstract Factory": AbstractFactory();
        break;
    case "Builder": Builder();
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
void AbstractFactory()
{
    Console.WriteLine("Please insert platform:");
    string platform = Console.ReadLine();
    UIService uiService = new UIService(platform);
    Console.WriteLine(uiService.OnClickButton());
    
}
void Builder()
{
    Console.WriteLine("Please insert game type:");
    string gameType = Console.ReadLine();
    GameService gameService = new GameService();
    gameService.CreateNewGame(gameType);
    Console.WriteLine(gameService.DescribeTheGame());
}

