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
                    Action("Player 1", npc);
                }
            } else
            {
                foreach(var npc in this._monsters)
                {
                    Console.WriteLine($"It's {npc.Name} turn..");
                    Action("Player 2", npc);
                }
            }

            Turn = !Turn;
            Thread.Sleep( 1000 );
        }

        private void Action(string player, Npc npc)
        {
            Console.WriteLine("What would you like to do? ");

            // ConsoleKey key = Console.ReadKey().Key;
            ConsoleKey key = Random.Shared.Next(0, 1) == -1 ? ConsoleKey.NumPad1 : ConsoleKey.NumPad1;

            switch (key)
            {
                case ConsoleKey.NumPad1:
                    Console.WriteLine($"{npc.Name} did nothing");
                    break;
            }
        }

    }
}
