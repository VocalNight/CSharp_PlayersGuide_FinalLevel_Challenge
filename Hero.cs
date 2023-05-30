using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PlayersGuide_FinalLevel_Challenge
{
    internal class Hero : Npc
    {
        public Hero( string name, int level, int hp, string attackName, int attackDamage ) : base(name, level, hp, attackName, attackDamage)
        {
            this.Team = Faction.Monsters;
        }

        public override void Attack( Npc enemy )
        {

            Console.WriteLine($"{Name} uses {AttackName} on {enemy.Name}");
            Console.WriteLine($"{AttackName} did {AttackDamage} damage to {enemy.Name}, health is now {enemy.CurrentHp - AttackDamage}/{enemy.Hp}");

            enemy.RemoveHealth(AttackDamage);
        }
    }
}
