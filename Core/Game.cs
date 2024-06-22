using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Blackjack
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        public static List<Entity> Entities { get; }

        private GraphicsDeviceManager m_graphics;
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
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            m_spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            foreach (var entity in Entities)
            {
                entity.Update();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            m_spriteBatch.Begin();
            foreach (var entity in Entities)
            {
                entity.Draw(m_spriteBatch);
            }
            m_spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}