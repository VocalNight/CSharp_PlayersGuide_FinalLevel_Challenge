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
                    Console.WriteLine($"It's {npc.Name}1 turn..");
                    Console.WriteLine($"{npc.Name} did nothing");
                }
            } else
            {
                foreach(var npc in this._monsters)
                {
                    Console.WriteLine($"It's {npc.Name} turn..");
                    Console.WriteLine($"{npc.Name} did nothing");
                }
            }

            Turn = !Turn;
            Thread.Sleep( 1000 );
        }

    }
}
