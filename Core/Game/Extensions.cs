using Microsoft.Xna.Framework;
using System;

namespace Blackjack
{
    public static class Extensions
    {
        public static Vector2 GetVertex(float angle, float x, float y)
        {
            return new Vector2(
                (float)Math.Cos(angle) * x,
                (float)Math.Sin(angle) * y
            );
        }
    }
}