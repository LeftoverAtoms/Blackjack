using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Blackjack.UI
{
    public sealed class Button : Image
    {
        public Button(Texture2D texture)
        {
            Texture = texture;

            Position = Game.WindowHalfSize;
            Size = new Vector2(512, 512);
        }

        public override void Update()
        {
            var mousePos = Mouse.GetState().Position;
            var mouseInput = Mouse.GetState().LeftButton;

            float halfWidth = (Size.X / 2);
            float halfHeight = (Size.Y / 2);

            if (mousePos.X >= Position.X - halfWidth
            && mousePos.X <= Position.X + halfWidth
            && mousePos.Y >= Position.Y - halfHeight
            && mousePos.Y <= Position.Y + halfHeight)
            {
                if (mouseInput == ButtonState.Pressed)
                {
                    Color = Color.Green;
                }
                else
                {
                    Color = Color.DarkGreen;
                }
            }
            else
            {
                Color = Color.DarkRed;
            }
        }
    }
}