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

        public Npc( string name, int level, string attackName)
        {
            this.Name = name;
            this.Level = level;
            this.AttackName = attackName;
        }

        public string Name { get; private set; }
        public int Level { get; private set; }
        protected string AttackName { get; set; }

        public Faction Team { get; protected set; }

        public abstract void Attack( Npc enemy );

    }
    public enum Faction { Heroes, Monsters }
}
