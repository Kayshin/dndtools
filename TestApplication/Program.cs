using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolCore.Classes.Mapping;
using ToolCore.Interfaces.Mapping;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //string uri = @"D:\Developing\Workshops en Eigen projecten\Kayshin's DND Tools\ToolCore\Resources\Map\Map1.xml";
            /*
            Map map = new Map() { TileDimensions = new Vector2(0, 0), Layer = new List<Layer>() { new Layer() { Tile = new Layer.TileMap() { Row = new List<string>() } } } };
            XMLManager<Map> mapLoader = new XMLManager<Map>();
            mapLoader.Save(@"D:\Developing\Workshops en Eigen projecten\Kayshin's DND Tools\ToolCore\Resources\Map\Map2.xml", map);
            //map = mapLoader.Load(uri);*/
            Console.ReadLine();
        }
    }
}
