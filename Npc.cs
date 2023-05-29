using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PlayersGuide_FinalLevel_Challenge
{
    internal abstract class Npc
    {

        public Npc( string name, int level, int hp, string attackName, int attackDamage)
        {
            this.Name = name;
            this.Level = level;
            this.AttackName = attackName;
            this.Hp = hp;
            this.CurrentHp = hp;
            this.AttackDamage = attackDamage;
        }

        public string Name { get; private set; }
        public int Level { get; private set; }
        protected string AttackName { get; set; }
        public int Hp { get; private set; }
        public int CurrentHp { get; private set; }
        public int AttackDamage { get; set; }

        public Faction Team { get; protected set; }

        public abstract void Attack( Npc enemy );

        public void RemoveHealth(int damage)
        {
            CurrentHp = CurrentHp - damage;
        }

    }
    public enum Faction { Heroes, Monsters }
}
