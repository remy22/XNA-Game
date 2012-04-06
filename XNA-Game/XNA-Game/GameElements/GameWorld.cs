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

using XNA_Game.Levels;
using XNA_Game.Sprites;
using XNA_Game.Sprites.Blocks;

namespace XNA_Game.GameElements
{
    /// <summary>
    /// This is the main class for the game
    /// </summary>
    public class GameWorld : Microsoft.Xna.Framework.Game
    {
        /// <summary>
        /// Handles the configuration and management of the graphics device.
        /// </summary>
        GraphicsDeviceManager graphics;

        /// <summary>
        /// Enables a group of sprites to be drawn using the same settings.
        /// </summary>
        SpriteBatch spriteBatch;

        /// <summary>
        /// Contains all of the images being used with the game.
        /// Images are stored as Texture2Ds and may be called by name.
        /// </summary>
        public static Dictionary<string, Texture2D> textures = new Dictionary<string, Texture2D>();

        /// <summary>
        /// Contains all of the levels being used with the game.
        /// Levels are stored as Levels and may be called by index.
        /// </summary>
        private static List<Level> levels = new List<Level>();

        /// <summary>
        /// The constructor for the game. Classes should be constructed here if possible.
        /// Graphics information should be initialized
        /// </summary>
        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);

            // Set the content directory
            Content.RootDirectory = "Content";

            // Set the window size
            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;

            //Fullscreen is false for testing
            graphics.IsFullScreen = false;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // On game initialization, content (such as images and music) is loaded into memory
            LoadContent();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load image
            textures.Add("Circle", Content.Load<Texture2D>("Images/Circle"));
            textures.Add("Block", Content.Load<Texture2D>("Images/Block"));

            // Create levels
            levels.Add(new Level(Content.Load<string>("Levels/Level1")));
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

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.Opaque);
            foreach(SpriteBase s in levels[0].currentLevel)
                    spriteBatch.Draw(textures[s.texture], s.location, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
