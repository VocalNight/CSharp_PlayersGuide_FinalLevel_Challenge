﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PlayersGuide_FinalLevel_Challenge
{
    internal class Hero : Npc
    {
        public Hero( string name, int level ) : base(name, level)
        {
            this.Team = Faction.Monsters;
        }
    }
}
