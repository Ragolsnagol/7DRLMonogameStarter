using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Tile : Entity
    {
        private bool walkable = false;

        public bool Walkable => walkable;

        public Tile(string sym, Vector2 pos, Color col, bool walk) : base(sym, pos, col)
        {
            walkable = walk;
        }
    }
}
