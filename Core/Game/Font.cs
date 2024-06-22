using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Blackjack.UI
{
    public static class Font
    {
        public static SpriteFont Arial { get; private set; }

        public static void LoadContent(ContentManager content)
        {
            Arial = content.Load<SpriteFont>("Fonts/Arial");
        }
    }
}