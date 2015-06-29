using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.IO;
using ToolCore.Classes;
using ToolCore.Interfaces;
using ToolCore.Enums;
using ToolCore.Interfaces.Mapping;
using ToolCore.Classes.Mapping;

namespace TileEngine
{
    public static class Extender
    {
        public static Dictionary<String, T> LoadContent<T>(this ContentManager contentManager, string contentFolder)
        {
            //Load directory info, abort if none
            DirectoryInfo dir = new DirectoryInfo(contentManager.RootDirectory + "\\" + contentFolder);
            if (!dir.Exists)
                throw new DirectoryNotFoundException();
            //Init the resulting list
            Dictionary<String, T> result = new Dictionary<String, T>();

            //Load all files that matches the file filter
            FileInfo[] files = dir.GetFiles("*.*");
            foreach (FileInfo file in files)
            {
                string key = Path.GetFileNameWithoutExtension(file.Name);

                result[key] = contentManager.Load<T>(contentFolder + "/" + key);
            }
            //Return the result
            return result;
        }
    }

    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        List<Texture2D> TileTextures = new List<Texture2D>();
        IMap map;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        Dictionary<string, KeyValuePair<string, Texture2D>> WallDict;

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            int screenWidth = GraphicsDevice.Viewport.Width;
            int screenHeight = GraphicsDevice.Viewport.Height;

            map = new Map(200, 200, screenHeight, screenWidth, 64, 64);
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Texture2D texture;

            /*WallDict = new Dictionary<string, KeyValuePair<string, Texture2D>>();

            Dictionary<string, Texture2D> theDict = Extender.LoadContent<Texture2D>(Content, "Tiles/Freewalls");

            TileTextures.AddRange(theDict.Values);*/

            texture = Content.Load<Texture2D>("Tiles/Freefloor/bones-1-4e-a");
            TileTextures.Add(texture);

            texture = Content.Load<Texture2D>("Tiles/Freefloor/bricks-1-4e-a");
            TileTextures.Add(texture);

            texture = Content.Load<Texture2D>("Tiles/Freefloor/cgtmoss-1-4e-a");
            TileTextures.Add(texture);

            texture = Content.Load<Texture2D>("Tiles/Freefloor/chunks-1L-4e-a");
            TileTextures.Add(texture);

            texture = Content.Load<Texture2D>("Tiles/Freefloor/grassy-1-4e-a");
            TileTextures.Add(texture);

            texture = Content.Load<Texture2D>("Tiles/Freefloor/grassy-1-4e-h");
            TileTextures.Add(texture);

            texture = Content.Load<Texture2D>("Tiles/Freefloor/gravel-1-4e-d");
            TileTextures.Add(texture);

            texture = Content.Load<Texture2D>("Tiles/Freefloor/oldpavement-2L-4e-b");
            TileTextures.Add(texture);

            texture = Content.Load<Texture2D>("Tiles/Freefloor/pavement-1-4e-c");
            TileTextures.Add(texture);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            KeyboardState keyState = Keyboard.GetState();
            Vector2 motion = Vector2.Zero;

            if (keyState.IsKeyDown(Keys.Up) || keyState.IsKeyDown(Keys.W))
                map.MoveCamera(Direction.Up);
            if (keyState.IsKeyDown(Keys.Down) || keyState.IsKeyDown(Keys.S))
                map.MoveCamera(Direction.Down);
            if (keyState.IsKeyDown(Keys.Left) || keyState.IsKeyDown(Keys.A))
                map.MoveCamera(Direction.Left);
            if (keyState.IsKeyDown(Keys.Right) || keyState.IsKeyDown(Keys.D))
                map.MoveCamera(Direction.Right);
            if (keyState.IsKeyDown(Keys.PageUp))
                map.CameraSpeed++;
            if (keyState.IsKeyDown(Keys.PageDown))
                map.CameraSpeed--;

            if (keyState.IsKeyDown(Keys.Escape))
                this.Exit();
         
            int screenWidth = GraphicsDevice.Viewport.Width;
            int screenHeight = GraphicsDevice.Viewport.Height;

            int tileMapWidth = map.TileMap.Width * map.TileWidth;
            int tileMapHeight = map.TileMap.Height * map.TileHeight;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            int tileMapWidth = map.TileMap.Width;
            int tileMapHeight = map.TileMap.Height;

            for (int x = 0; x < tileMapWidth; x++)
            {
                for (int y = 0; y < tileMapHeight; y++)
                {
                    int textureIndex = map.TileMap.GetTile(x, y);
                    Texture2D texture = TileTextures[textureIndex];

                    spriteBatch.Draw(
                        texture,
                        new Rectangle(
                            x * map.TileWidth - (int)map.CameraPosition.X,
                            y * map.TileHeight - (int)map.CameraPosition.Y,
                            map.TileWidth,
                            map.TileHeight),
                        Color.White);
                }
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
