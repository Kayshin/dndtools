using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolCore;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon;
            weapon = new Sword();
            Console.WriteLine(weapon.Id); 
            Console.WriteLine(weapon.Name);
            Console.WriteLine(weapon.Value);
            Console.WriteLine(weapon.DamageType);
            Console.ReadLine();
        }
    }
}
