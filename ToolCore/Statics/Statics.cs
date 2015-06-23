using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolCore
{
    static class Statics
    {
        public static bool Debug = true;

        public static string DefaultImage = "";
        public static IPlayer DungeonMaster = new DungeonMaster();
    }
}
