using CSharp_PlayersGuide_FinalLevel_Challenge;

Console.Write("What's the name of the player character? ");
string? playerName = Console.ReadLine();

Monster skeleton = new Monster("Skeleton", 1, "bone crunch");
Hero hero = new Hero(playerName, 1, "punch");


List<Hero> heroes = new List<Hero> { hero };
List<Monster> monsters = new List<Monster> { skeleton };

Game game = new(heroes, monsters);

while (true)
{
    game.PlayRound();
}