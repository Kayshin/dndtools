using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore
{
    public class Player : TokenHandler, IPlayer
    {
        public Player(string name): base(name)
        {        }
    }

    public class DungeonMaster : Player
    {
        public DungeonMaster()
            : base("DungeonMaster")
        { }
    }
}
