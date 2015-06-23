using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore
{
    public interface ITile : ICore, ITokenHandler
    {
        /// <summary>
        /// Image of the Tile
        /// </summary>
        string Image
        {
            get;
            set;
        }

        /// <summary>
        /// Type of terrain
        /// </summary>
        TerrainType TerrainType
        {
            get;
            set;
        }

        /// <summary>
        /// Tile connecting on Top side
        /// </summary>
        ITile Top
        {
            get;
            set;
        }

        /// <summary>
        /// Tile connecting on Right side
        /// </summary>
        ITile Right
        {
            get;
            set;
        }

        /// <summary>
        /// Tile connecting on Bottom side
        /// </summary>
        ITile Bottom
        {
            get;
            set;
        }

        /// <summary>
        /// Tile connecting on Left side
        /// </summary>
        ITile Left
        {
            get;
            set;
        }
    }
}
