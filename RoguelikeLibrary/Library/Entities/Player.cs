using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Library.Entities
{
    public class Player : Actor
    {
        public Player(string sym, Vector2 pos, Color col) : base(sym, pos, col)
        {

        }

        public override void Update(GameTime gameTime)
        {
            if (InputHandler.KeyReleased(Keys.W))
            {
                Move(new Vector2(0, -1));
            }
            else if (InputHandler.KeyReleased(Keys.S))
            {
                Move(new Vector2(0, 1));
            }
            else if (InputHandler.KeyReleased(Keys.A))
            {
                Move(new Vector2(-1, 0));
            }
            else if (InputHandler.KeyReleased(Keys.D))
            {
                Move(new Vector2(1, 0));
            }
        }
    }
}
