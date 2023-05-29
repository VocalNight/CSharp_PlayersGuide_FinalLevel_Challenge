using CSharp_PlayersGuide_FinalLevel_Challenge;

Console.Write("What's the name of the player character? ");
string? playerName = Console.ReadLine();

Monster skeleton = new Monster("Skeleton", 1, 5, "bone crunch");
Monster skeleton2 = new Monster("Skeleton", 1, 5, "bone crunch");
Monster skeleton3 = new Monster("Skeleton", 1, 5, "bone crunch");
Monster skeleton4 = new Monster("Skeleton", 1, 5, "bone crunch");
Monster skeleton5 = new Monster("Skeleton", 1, 5, "bone crunch");
Monster MegaSkeleton = new Monster("Skeleton", 1, 7, "bone crunch");
Hero hero = new Hero(playerName, 1, 25, "punch");


List<Hero> heroes = new List<Hero> { hero };
List<Monster> monsters = new List<Monster> { skeleton, skeleton2 };

Game game = new(heroes, monsters);

while (true)
{
    int gameContinues = game.PlayRound();

    if (gameContinues == 0)
        break;
}