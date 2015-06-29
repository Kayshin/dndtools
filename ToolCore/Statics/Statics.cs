using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolCore.Classes;
using ToolCore.Interfaces;

namespace ToolCore.Statics
{
    static class StaticValues
    {
        public static bool Debug = true;

        public static string DefaultImage = "";
        public static float CameraSpeed = 5;
        public static IPlayer DungeonMaster = new DungeonMaster();
    }
}
