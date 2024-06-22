using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Blackjack
{
    public abstract class Entity
    {
        public Vector2 Position { get; set; }
        public Vector2 Size { get; set; } = new Vector2(256, 256);

        public Entity()
        {
            Game.Entities.Add(this);
        }
        public virtual void Destroy()
        {
            Game.Entities.Remove(this);
        }

        public abstract void Update();
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}