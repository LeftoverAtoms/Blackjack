using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Blackjack.UI
{
    public class Image : Entity
    {
        public Texture2D Texture { get; set; }
        public Rectangle? Source { get; set; } = null;
        public Color Color { get; set; } = Color.White;
        public float Layer { get; set; } = 0;

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
            var center = new Vector2(Size.X / 2, Size.Y / 2);
            spriteBatch.Draw(Texture, rect, Source, Color, 0, center, SpriteEffects.None, Layer);
        }
    }
}