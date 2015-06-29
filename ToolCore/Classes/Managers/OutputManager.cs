using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ToolCore.Interfaces.Managers;

namespace ToolCore.Classes.Managers
{
    class ConsoleOutputManager : Core, IOutputManager
    {
        public ConsoleOutputManager()
            : base("ConsoleOutputManager")
        { }

        public void Write(string theString)
        {
            Console.WriteLine(theString);
        }
    }

    class DebugOutputManagr : Core, IOutputManager
    {
        public DebugOutputManagr()
            : base("DebugOutputManager")
        { }

        public void Write(string theString)
        {
            Debug.WriteLine(theString);
        }
    }
}
