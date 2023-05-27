using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PlayersGuide_FinalLevel_Challenge
{
    internal class Npc
    {

        public Npc( string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public string Name { get; private set; }
        public int Level { get; private set; }

        public Faction Team { get; protected set; }

    }
    public enum Faction { Heroes, Monsters }
}
