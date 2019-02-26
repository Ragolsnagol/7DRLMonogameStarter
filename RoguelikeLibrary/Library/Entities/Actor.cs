using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Library.Entities
{
    // This class contains everything that is common for any sort of NPC and the player.
    // That is movement, stats, taking damage, etc.
    public class Actor : Entity
    {
        public Actor(string sym, Vector2 pos, Color col) : base(sym, pos, col)
        {

        }

        protected void Move(Vector2 direction)
        {
            Vector2 newPosition = position + direction;

            if (newPosition.X < 0 || newPosition.X > Engine.BlockedMap.GetLength(0) - 1 || newPosition.Y < 0 || newPosition.Y > Engine.BlockedMap.GetLength(1) - 1)
            {
                return;
            }

            if (Engine.BlockedMap[(int)newPosition.X, (int)newPosition.Y] == 0)
            {
                position = newPosition;
            }
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
