// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Please insert card pan:");
string cardPan = Console.ReadLine();
CardService cardService = new CardService();
Console.WriteLine(cardService.GetCardBalanceByCardPan(cardPan));