using Blackjack.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Blackjack
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        public static BasePawn LocalClient { get; private set; }

        public static List<Entity> Entities { get; }

        public static Vector2 WindowSize { get; private set; }
        public static Vector2 WindowHalfSize { get; private set; }

        private static GraphicsDeviceManager m_graphics;
        private SpriteBatch m_spriteBatch;

        static Game()
        {
            Entities = new List<Entity>();
        }
        public Game()
        {
            m_graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            SetWindowSize(1920, 1080);

            LocalClient = new Human();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            m_spriteBatch = new SpriteBatch(GraphicsDevice);

            Font.LoadContent(Content);
            Card.LoadContent(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            // TODO: Make menu appear.
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            foreach (var entity in Entities)
            {
                entity.Update();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            m_spriteBatch.Begin(SpriteSortMode.FrontToBack);
            foreach (var entity in Entities)
            {
                entity.Draw(m_spriteBatch);
            }
            m_spriteBatch.End();

            base.Draw(gameTime);
        }

        public static void SetWindowSize(int width, int height)
        {
            WindowSize = new Vector2(width, height);
            WindowHalfSize = WindowSize / 2;

            m_graphics.PreferredBackBufferWidth = width;
            m_graphics.PreferredBackBufferHeight = height;
            m_graphics.ApplyChanges();
        }
    }
}