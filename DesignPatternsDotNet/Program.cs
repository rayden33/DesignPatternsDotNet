using Creational.AbstractFactory;
using Creational.Builder;
using Creational.FactoryMethod;
using Creational.Prototype;
using Creational.Singleton;
using Structural.Adapter;
using Structural.Bridge;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please select catalog:(Creational, Structural, Behavioral)");
string catalog = Console.ReadLine();
switch(catalog)
{
    case "Creational": Creational();
        break;
    case "Structural": Structural();
        break;
    case "Behavioral": Builder();
        break;
    default: throw new Exception("Undefined catalog");
}




void Creational()
{
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
}

void Structural()
{
    Console.WriteLine("Please select pattern:");
    string pattern = Console.ReadLine();

    switch(pattern)
    {
        case "Adapter": Adapter();
            break;
        case "Bridge": Bridge();
            break;
        default: throw new Exception("Undefined pattern");
    }
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

void Adapter()
{
    Console.WriteLine("Please insert input type");
    string inputType = Console.ReadLine();
    PhoneInputInterfaceService inputInterface = new PhoneInputInterfaceService(inputType);
    inputInterface.VirtualPhoneClickAllButton();
}

void Bridge()
{
    Console.WriteLine("Please select smart home command:");
    Console.WriteLine("0 - Wake Up");
    Console.WriteLine("1 - Preparing Home");
    int commandId = Convert.ToInt32(Console.ReadLine());
    SmartHomeService smartHomeService = new SmartHomeService();
    switch(commandId)
    {
        case 0: smartHomeService.WakeUp(); break;
        case 1: Console.WriteLine(smartHomeService.PreparingHome()); break;
        default: throw new Exception("Undefined command");
    }
}

