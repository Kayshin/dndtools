using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolCore.Classes.Managers;
using ToolCore.Interfaces;
using ToolCore.Interfaces.Managers;
using ToolCore.Statics;

namespace ToolCore.Classes
{
    public class Core : ICore
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        private IEnumerable<IOutputManager> OutputManagers { get; set; }

        public Core()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;

            if (!AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IOutputManager).IsAssignableFrom(p))
                .Contains(this.GetType()))
            {
                OutputManagers = new List<IOutputManager>();
                ((List<IOutputManager>)OutputManagers).Add(new ConsoleOutputManager());
                ((List<IOutputManager>)OutputManagers).Add(new DebugOutputManagr());
            }
        }

        public Core(string name)
            : this()
        {
            Name = name;
        }

        public void Print()
        {
            foreach (IOutputManager opm in OutputManagers)
            {
                opm.Write(this.ToString());
            }
        }

        public override string ToString()
        {
            var retVal = string.Empty;
            if (StaticValues.Debug)
            {
                retVal += string.Format("ID: {0}", Id);
            }
            retVal += string.Format("\nName: {0}", Name);
            return retVal;
        }
    }
}
