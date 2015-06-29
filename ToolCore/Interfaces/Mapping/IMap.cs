using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using ToolCore.Enums;

namespace ToolCore.Interfaces.Mapping
{
    public interface IMap : ICore
    {
        ITileMap TileMap { get; }

        int TileWidth
        {
            get;
            set;
        }

        int TileHeight
        {
            get;
            set;
        }

        int Width
        {
            get;
            set;
        }

        int Height
        {
            get;
            set;
        }

        Vector2 CameraPosition { get; }

        float CameraSpeed
        {
            get;
            set;
        }

        Vector2 Motion { get; }

        void MoveCamera(Direction direction);
    }
}
