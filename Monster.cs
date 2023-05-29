using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PlayersGuide_FinalLevel_Challenge
{
    internal class Monster : Npc
    {
        public Monster(string name, int level, string attackName) : base(name, level, attackName) 
        {
                this.Team = Faction.Monsters;
        }

        public override void Attack( Npc enemy )
        {
            Console.WriteLine($"{Name} uses {AttackName} on {enemy.Name}");
        }
    }
}
