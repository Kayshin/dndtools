using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore
{
    public class Tile : TokenHandler, ITile
    {

        public string Image { get; set; }
        public TerrainType TerrainType { get; set; }

        public ITile Top { get; set; }
        public ITile Right { get; set; }
        public ITile Bottom { get; set; }
        public ITile Left { get; set; }

        private Tile()
            : base()
        { }

        public Tile(TerrainType terrainType, string image)
            : this()
        {
            TerrainType = terrainType;
            Image = image;
        }

        public Tile(TerrainType terrainType)
            : this(terrainType, Statics.DefaultImage)
        { }
    }
}
