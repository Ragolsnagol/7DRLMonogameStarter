using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Library.Entities
{
    public class Entity : IEntity
    {
        protected Vector2 position;
        protected string symbol;
        protected Color color;

        public Entity(string sym, Vector2 pos, Color col)
        {
            symbol = sym;
            position = pos;
            color = col;
        }


        public virtual void Draw(SpriteBatch spriteBatch, SpriteFont font)
        {
            spriteBatch.DrawString(font, symbol, position * Engine.CharacterSize, color);
        }

        public virtual void Update(GameTime gameTime)
        {
            
        }
    }
}
