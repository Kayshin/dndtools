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
            ITile tile = new Tile(TerrainType.Normal);
            tile.Name = "Appel";
            tile.AddToken(new Token(100));
            tile.Print();
            Console.WriteLine();
            tile.PrintTokens();
            
            IPlayer dm = new DungeonMaster();
            dm.AddToken(new Token(100));
            dm.AddToken(new Token(100));
            dm.AddToken(new Token(100));
            dm.AddToken(new Token(100));
            dm.AddToken(new Token(100));
            Console.WriteLine();
            dm.Print();
            Console.WriteLine();
            dm.PrintTokens();
            Console.ReadLine();
        }
    }
}
