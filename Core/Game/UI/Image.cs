using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Blackjack.UI
{
    public class Image : Entity
    {
        private Texture2D m_texture;
        private Color m_color = Color.White;

        public Image(Texture2D texture) : base()
        {
            m_texture = texture;
        }

        public override void Update() { }
        public override void Draw(SpriteBatch spriteBatch)
        {
            var rect = new Rectangle((int)Position.X, (int)Position.Y, (int)Size.X, (int)Size.Y);
            spriteBatch.Draw(m_texture, rect, null, m_color, 0, Vector2.Zero, SpriteEffects.None, 0);
        }
    }
}