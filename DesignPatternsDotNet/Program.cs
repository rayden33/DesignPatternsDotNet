using Creational.AbstractFactory;
using Creational.Builder;
using Creational.FactoryMethod;
using Creational.Prototype;
using Creational.Singleton;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please select catalog:");
string catalog = Console.ReadLine();
switch(catalog)
{
    case "Creational": FactoryMethod();
        break;
    case "Structural": AbstractFactory();
        break;
    case "Behavioral": Builder();
        break;
    default: throw new Exception("Undefined catalog");
}


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
    case "Prototype": Prototype();
        break;
    case "Singleton": Singleton();
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
void Prototype()
{
    Console.WriteLine("Start experiment");
    LabaratoryService labaratoryService = new LabaratoryService();
    string result = labaratoryService.ExperimentWithCells();
    Console.WriteLine(result);
}
void Singleton()
{
    Console.WriteLine("Please insert connections count:");
    int conCount = Convert.ToInt32(Console.ReadLine());
    for(int i=0;i<conCount;i++)
    {
        Task task = new Task(() => {
            DatabaseService database = new DatabaseService();
            Console.WriteLine(database.GetConnectionSessionId());
        });

        task.Start();
    }
    Console.ReadLine();
}

