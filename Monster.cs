using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PlayersGuide_FinalLevel_Challenge
{
    internal class Monster : Npc
    {
        public Monster(string name, int level, int hp, string attackName) : base(name, level, hp, attackName) 
        {
                this.Team = Faction.Monsters;
        }

        public override void Attack( Npc enemy )
        {
            int damage = Random.Shared.Next(2);

            Console.WriteLine($"{Name} uses {AttackName} on {enemy.Name}");
            Console.WriteLine($"{AttackName} did {damage} damage to {enemy.Name}, health is now {enemy.CurrentHp - damage}/{enemy.Hp}");

            enemy.RemoveHealth( damage );
        }
    }
}
