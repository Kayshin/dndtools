using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolCore.Interfaces;
using ToolCore.Statics;

namespace ToolCore.Classes
{
    public class Token : Core, IToken
    {
        public int Initiative { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int TempHealth { get; set; }

        public Token()
        {
            Name = "EmptyToken";

            Initiative = 0;
            MaxHealth = 0;
            CurrentHealth = 0;
            TempHealth = 0;
        }

        public Token(int maxHealth)
            : this()
        {
            MaxHealth = maxHealth;
        }

        public Token(int maxHealth, int currentHealth, int tempHealth, int initiative)
            : this(maxHealth)
        {
            if (currentHealth > maxHealth)
            {
                CurrentHealth = maxHealth;
            }
            else
            {
                CurrentHealth = currentHealth;
            }
            TempHealth = tempHealth;
            Initiative = initiative;
        }

        public new void Print()
        {
            if (StaticValues.Debug)
            {
                Console.WriteLine(string.Format("ID: {0}", Id));
            }
            Console.WriteLine(string.Format("Name: {0}", Name));
            Console.WriteLine(string.Format("Init: {0} - HP: {1}/{2} ({3} tmp)", Initiative, CurrentHealth, MaxHealth, TempHealth));
        }
    }
}
