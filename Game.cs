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

        public void PlayRound()
        {
            if (Turn == true)
            {
                foreach (var npc in this._heroes)
                {
                    Console.WriteLine($"It's {npc.Name} turn..");
                    int enemy = Random.Shared.Next(0, this._monsters.Count);
                    Action("Player 1", npc, this._monsters[enemy]);
                }
            } else
            {
                foreach(var npc in this._monsters)
                {
                    Console.WriteLine($"It's {npc.Name} turn..");
                    int enemy = Random.Shared.Next(0, this._heroes.Count);
                    Action("Player 2", npc, this._heroes[enemy]);
                }
            }

            Turn = !Turn;
            Thread.Sleep( 1000 );
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

    }
}
