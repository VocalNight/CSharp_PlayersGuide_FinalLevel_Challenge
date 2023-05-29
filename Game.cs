using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PlayersGuide_FinalLevel_Challenge
{
    internal class Game
    {
        public Game(List<Hero> heroes, List<Monster> monsters) {
            this._monsters = monsters;
            this._heroes = heroes;
            this.Turn = true;
        }

        private List<Hero> _heroes;
        private List<Monster> _monsters;
        private bool Turn { get; set; }

        public int PlayRound()
        {
            if (Turn == true)
            {
                foreach (var npc in this._heroes)
                {
                    int enemy = Random.Shared.Next(0, this._monsters.Count);
                    Console.WriteLine($"It's {npc.Name} turn..");

                    Action("Player 1", npc, this._monsters[enemy]);
                }
            } else
            {
                foreach(var npc in this._monsters)
                {
                    int enemy = Random.Shared.Next(0, this._heroes.Count);
                    Console.WriteLine($"It's {npc.Name} turn..");

                    Action("Player 2", npc, this._heroes[enemy]);
                }
            }

            CheckDead();

            if (this._heroes.Count == 0)
            {
                Console.WriteLine("The monsters win!");
                return 0;
            } else if (this._monsters.Count == 0)
            {
                Console.WriteLine("The heroes win!");
                return 0;
            }

            Turn = !Turn;
            Thread.Sleep( 1000 );
            return 1;
        }

        private void Action(string player, Npc npc, Npc enemy)
        {
            Console.WriteLine("What would you like to do? ");

            // ConsoleKey key = Console.ReadKey().Key;
            ConsoleKey key = Random.Shared.Next(0, 2) == 0  ? ConsoleKey.NumPad1 : ConsoleKey.NumPad2;

            switch (key)
            {
                case ConsoleKey.NumPad1:
                    Console.WriteLine($"{npc.Name} did nothing");
                    break;
                case ConsoleKey.NumPad2:
                    npc.Attack(enemy);
                    break;
            }
        }

        private void CheckDead()
        {
            this._heroes = this._heroes.Where(hero => hero.CurrentHp > 0).ToList();
            this._monsters = this._monsters.Where(monster =>
            {
                if (monster.CurrentHp == 0) {
                    Console.WriteLine($"{monster.Name} has been defeated");
                }

                return monster.CurrentHp > 0;
            }).ToList();
        }

    }
}
