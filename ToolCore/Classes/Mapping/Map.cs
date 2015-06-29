using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolCore.Enums;
using ToolCore.Interfaces.Mapping;
using ToolCore.Statics;

namespace ToolCore.Classes.Mapping
{
    public class Map : Core, IMap
    {
        private int ScreenWidth { get; set; }
        private int ScreenHeight { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public ITileMap TileMap { get; set; }

        public int TileWidth { get; set; }
        public int TileHeight { get; set; }
        
        private Vector2 _cameraPosition = Vector2.Zero;
        public Vector2 CameraPosition { get; set; }
        public float CameraSpeed { get; set; }

        private Vector2 _motion = Vector2.Zero;
        public Vector2 Motion { get { return _motion; } }

        public Map()
            : base("Map")
        {
            Width = 0;
            Height = 0;
            TileWidth = 0;
            TileHeight = 0;
            CameraSpeed = 0;
            TileMap = new TileMap();
            TileMap.FillMap();
        }

        public Map(float cameraSpeed)
            : this()
        {
            CameraSpeed = cameraSpeed;
        }

        public Map(int height, int width, int screenHeight, int screenWidth, int tileHeight, int tileWidth)
            : this(StaticValues.CameraSpeed)
        {
            Height = height;
            Width = width;
            TileHeight = tileHeight;
            TileWidth = tileWidth;
            ScreenHeight = screenHeight;
            ScreenWidth = screenWidth;
        }

        public void MoveCamera(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    _motion.Y--;
                    break;
                case Direction.Right:
                    _motion.X++;
                    break;
                case Direction.Down:
                    _motion.Y++;
                    break;
                case Direction.Left:
                    _motion.X--;
                    break;
                default:
                    break;
            }

            if (_motion != Vector2.Zero)
            {
                _motion.Normalize();
                _cameraPosition += _motion * CameraSpeed;
            }

            if (_cameraPosition.X < 0)
                _cameraPosition.X = 0;
            if (_cameraPosition.Y < 0)
                _cameraPosition.Y = 0;

            if (_cameraPosition.X > TileMap.Width - ScreenWidth)
                _cameraPosition.X = TileMap.Width -ScreenWidth;
            if (_cameraPosition.Y > TileMap.Height - ScreenHeight)
                _cameraPosition.Y = TileMap.Height - ScreenHeight;

        }
    }
}
