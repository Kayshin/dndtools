using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolCore.Enums;
using ToolCore.Interfaces.Mapping;
using ToolCore.Statics;

namespace ToolCore.Classes.Mapping
{
    public class Tile : TokenHandler, ITile
    {
        public string Image { get; set; }
        public TerrainType TerrainType { get; set; }
        public int SourceX { get; set; }
        public int SourceY { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public bool IsSolid { get; set; }

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
            : this(terrainType, StaticValues.DefaultImage)
        { }


        public void Clear()
        {
            throw new NotImplementedException();
        }

        public ITile Clone()
        {
            throw new NotImplementedException();
        }
    }
}
