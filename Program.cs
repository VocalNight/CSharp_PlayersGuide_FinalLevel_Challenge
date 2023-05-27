using CSharp_PlayersGuide_FinalLevel_Challenge;

Monster skeleton = new Monster("Skeleton", 1);
Hero hero = new Hero("Skeleton", 1);

List<Hero> heroes = new List<Hero> { hero };
List<Monster> monsters = new List<Monster> { skeleton };

Game game = new(heroes, monsters);

while (true)
{
    game.PlayRound();
}