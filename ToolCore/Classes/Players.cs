using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolCore.Interfaces;
using ToolCore.Interfaces.Mapping;

namespace ToolCore.Classes
{
    public class BasePlayer : TokenHandler, IPlayer
    {
        public BasePlayer(string name)
            : base(name)
        { }
    }

    public class DungeonMaster : BasePlayer
    {
        public DungeonMaster()
            : base("DungeonMaster")
        { }

        public DungeonMaster(string name)
            : base(name)
        { }
    }

    public class Player : BasePlayer
    {
        public Player()
            : base("Player")
        { }

        public Player(string name)
            : base(name)
        { }
    }

    public class Monster : BasePlayer
    {
        public Monster()
            : base("Monster")
        { }

        public Monster(string name)
            : base(name)
        { }
    }
}
