using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Blackjack.UI
{
    public class Label : Entity
    {
        public string Text { get; set; } = "Default";
        public Color Color { get; set; } = Color.White;

        public Label()
        {
        }
        public Label(string text)
        {
            Text = text;
        }

        public override void Update() { }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(Font.Arial, Text, Position, Color, 0, Vector2.Zero, 1f, SpriteEffects.None, 0);
        }
    }
}