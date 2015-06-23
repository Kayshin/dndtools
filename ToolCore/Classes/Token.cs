using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore
{
    public class Token : Core, IToken
    {
        public IPlayer Owner { get; set; }

        public int Initiative { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int TempHealth { get; set; }

        public Token()
        {
            Owner = new DungeonMaster();

            Name = "EmptyToken";

            Initiative = 0;
            MaxHealth = 0;
            CurrentHealth = 0;
            TempHealth = 0;
        }

        public Token(int maxHealth): this()
        {
            MaxHealth = maxHealth;
        }

        public new void Print()
        {
            if (Statics.Debug)
            {
                Console.WriteLine(string.Format("ID: {0}", Id));
            }
            Console.WriteLine(string.Format("Name: {0}", Name));
            Console.WriteLine(string.Format("Init: {0} - HP: {1}/{2} ({3} tmp)", Initiative, CurrentHealth, MaxHealth, TempHealth));
        }
    }
}
