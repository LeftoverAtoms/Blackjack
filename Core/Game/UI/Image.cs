using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Blackjack.UI
{
    public class Image : Entity
    {
        public Texture2D Texture { get; set; }
        public Color Color { get; set; } = Color.White;

        public Image()
        {
        }
        public Image(Texture2D texture)
        {
            Texture = texture;
        }

        public override void Update() { }
        public override void Draw(SpriteBatch spriteBatch)
        {
            var rect = new Rectangle((int)Position.X, (int)Position.Y, (int)Size.X, (int)Size.Y);
            spriteBatch.Draw(Texture, rect, null, Color, 0, Vector2.Zero, SpriteEffects.None, 0);
        }
    }
}