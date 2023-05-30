using CSharp_PlayersGuide_FinalLevel_Challenge;

Console.Write("What's the name of the player character? ");
string? playerName = Console.ReadLine();

Console.WriteLine("What type of game you want to play?");
Console.WriteLine(@"
1 - CPU vs CPU
2 - Player vs CPU
3 - Player vs Player");
ConsoleKey key = Console.ReadKey(true).Key;

int gameMode = key switch
{
    ConsoleKey.NumPad1 => 1,
    ConsoleKey.NumPad2 => 2,
    ConsoleKey.NumPad3 => 3,
};




Monster skeleton = new Monster("Skeleton", 1, 5, "bone crunch", 1);
Monster skeleton2 = new Monster("Skeleton", 1, 5, "bone crunch", 1);
Monster UncodedOne = new Monster("The Uncoded One", 1, 15, "Unraveling attack", 2);


List<Monster> firstParty = new() { skeleton };
List<Monster> secondParty = new() { skeleton, skeleton2 };
List<Monster> finalParty = new() { UncodedOne };

Hero hero = new Hero(playerName, 1, 25, "punch", 1);


List<Hero> heroes = new List<Hero> { hero };
List<List<Monster>> monsters = new() { firstParty, secondParty, finalParty };

Game game = new(heroes, monsters);

while (true)
{

    bool gameContinues = game.PlayRound(gameMode);


    if (gameContinues)
        break;
}