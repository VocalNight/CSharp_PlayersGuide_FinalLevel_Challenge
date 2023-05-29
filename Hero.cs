using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PlayersGuide_FinalLevel_Challenge
{
    internal class Hero : Npc
    {
        public Hero( string name, int level, int hp, string attackName ) : base(name, level, hp, attackName)
        {
            this.Team = Faction.Monsters;            
        }

        public override void Attack(Npc enemy)
        {

            Console.WriteLine($"{Name} uses {AttackName} on {enemy.Name}");
            Console.WriteLine($"{AttackName} did 1 damage to {enemy.Name}, health is now {enemy.CurrentHp - 1}/{enemy.Hp}");

            enemy.RemoveHealth(1);
        }
    }
}
