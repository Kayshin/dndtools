using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore
{
    public class Core : ICore
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Core()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
        }

        public Core(string name): this()
        {
            Name = name;
        }

        public void Print()
        {
            if (Statics.Debug)
            {
                Console.WriteLine(string.Format("ID: {0}", Id));
            }
            Console.WriteLine(string.Format("Name: {0}", Name));
        }
    }
}
