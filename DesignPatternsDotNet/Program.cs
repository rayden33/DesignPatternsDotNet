using Creational.AbstractFactory;
using Creational.Builder;
using Creational.FactoryMethod;
using Creational.Prototype;
using Creational.Singleton;
using Structural.Adapter;
using Structural.Bridge;
using Structural.Composite;
using Structural.Decorator;
using Structural.Facade;
using Structural.Flyweight;
using Structural.Proxy;
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
        case "Composite": Composite();
            break;
        case "Decorator": Decorator();
            break;
        case "Facade": Facade();
            break;
        case "Flyweight": Flyweight();
            break;
        case "Proxy": Proxy();
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

void Composite()
{
    GameSceneService gameSceneService = new GameSceneService();
    List<GameObject> allGameObjects = new List<GameObject>();
    Console.WriteLine("Please insert Container count:");
    int count = Convert.ToInt32(Console.ReadLine());
    Container mainContainer = new Container(0,0);
    Container tmpContainer = mainContainer;
    for(int i=0;i<count;i++)
    {
        Container cnt = new Container(0,i);
        tmpContainer.AddChild(cnt);
        tmpContainer = cnt;
        allGameObjects.Add(cnt);
    }

    Console.WriteLine("Please insert Cube count:");
    count = Convert.ToInt32(Console.ReadLine());
    for(int i=0;i<count;i++)
    {
        Cube cb = new Cube(i,0);
        tmpContainer.AddChild(cb);
        allGameObjects.Add(cb);
    }
    Console.WriteLine("Objects positions before moving:");

    foreach(GameObject obj in allGameObjects)
    {
        if(obj is Container)
            Console.WriteLine($"Container : {obj.X}-{obj.Y}");
        else
            Console.WriteLine($"Cube : {obj.X}-{obj.Y}");
    }

    mainContainer.UnitedMovement(1,1);

    Console.WriteLine("Objects positions after moving:");

    foreach(GameObject obj in allGameObjects)
    {
        if(obj is Container)
            Console.WriteLine($"Container : {obj.X}-{obj.Y}");
        else
            Console.WriteLine($"Cube : {obj.X}-{obj.Y}");
    }

}

void Decorator()
{
    Console.WriteLine("Please select notify level:");
    Console.WriteLine("0 - Only SMS");
    Console.WriteLine("1 - SMS and Email");
    Console.WriteLine("2 - SMS, Email and Facebook");
    int level = Convert.ToInt32(Console.ReadLine());

    SmsNotifier smsNotifier = new SmsNotifier();

    Notifier notifier = smsNotifier;

    if(level > 0)
        notifier = new EmailNotifierDecorator(notifier);
    
    if(level > 1)
        notifier = new FacebookNotifierDecorator(notifier);


    NotifierService notifierService = new NotifierService(notifier);
    Console.WriteLine(notifierService.NotifyClient("Hello world"));
}

void Facade()
{
    GameCreatorFacade creatorFacade = new GameCreatorFacade();
    Console.WriteLine("Please insert player name:");
    string playerName = Console.ReadLine();
    Console.WriteLine(creatorFacade.CreateRandomGameDescription(playerName));
}

void Flyweight()
{
    ForestService forestService = new ForestService();
    Console.WriteLine("Please insert green trees and red trees count:");
    int greenCount = Convert.ToInt32(Console.ReadLine());
    int redCount = Convert.ToInt32(Console.ReadLine());
    forestService.GenerateTrees(greenCount, redCount);
    Console.WriteLine(forestService.GetForestTreesFruits());
}

void Proxy()
{
    MarketApi marketApi = new MarketApi();
    MarketApiCacheService marketApiCacheService = new MarketApiCacheService(marketApi);
    MarketService marketService = new MarketService(marketApiCacheService);

    Console.WriteLine("Please insert request count:");
    int requestCount = Convert.ToInt32(Console.ReadLine());

    for(int i=0;i<requestCount;i++)
        Console.WriteLine(marketService.GetProductInfo(1));
    
    Console.WriteLine($"Requested count to api is {marketApi.GetApiRequestedCount()}");
}

