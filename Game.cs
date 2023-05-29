﻿namespace CSharp_PlayersGuide_FinalLevel_Challenge
{
    internal class Game
    {
        public Game(List<Hero> heroes, List<List<Monster>> monsters) {
            this._monsters = monsters;
            this._heroes = heroes;
            this.Turn = true;
            this.CurrentMonsterParty = monsters[0];
        }

        private List<Hero> _heroes;
        private List<List<Monster>> _monsters { get; set; }
        private List<Monster> CurrentMonsterParty { get; set; }
        private bool Turn { get; set; }

        public bool PlayRound()
        {
            if (Turn == true)
            {
                foreach (var npc in this._heroes)
                {
                    int enemy = Random.Shared.Next(0, this.CurrentMonsterParty.Count);
                    Console.WriteLine($"It's {npc.Name} turn..");

                    Action("Player 1", npc, this.CurrentMonsterParty[enemy]);
                }
            } else
            {
                foreach(var npc in this.CurrentMonsterParty)
                {
                    int enemy = Random.Shared.Next(0, this._heroes.Count);
                    Console.WriteLine($"It's {npc.Name} turn..");

                    Action("Player 2", npc, this._heroes[enemy]);
                }
            }
            Console.WriteLine("-----");

            CheckDead();

            bool hasGameEnded = false;

            if (this._heroes.Count == 0)
            {
                Console.WriteLine("The monsters win!");
                hasGameEnded = true;

            } else if (this.CurrentMonsterParty.Count == 0 && this._monsters.Count > 0)
            {
              hasGameEnded = CallReinforcements();
            }

            Turn = !Turn;
            Thread.Sleep( 1000 );
            return hasGameEnded;
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
            this.CurrentMonsterParty = this.CurrentMonsterParty.Where(monster =>
            {
                if (monster.CurrentHp == 0) {
                    Console.WriteLine($"{monster.Name} has been defeated");
                }

                return monster.CurrentHp > 0;
            }).ToList();
        }

        private bool CallReinforcements()
        {
            this._monsters.RemoveAt(0);
            if (this._monsters.Count > 0) 
            {
                this.CurrentMonsterParty = this._monsters[0];
                Console.WriteLine("More enemies have spawned!");
            } else
            {
                Console.WriteLine("The heroes win!");
                return true;
            }
            return false;
        }
    }
}
