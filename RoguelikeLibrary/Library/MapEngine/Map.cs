using Library.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.MapEngine
{
    public class Map
    {
        private Tile[,] tiles;
        private int width;
        private int height;

        public Map(int w, int h)
        {
            width = w;
            height = h;

            tiles = new Tile[width, height];
        }

        public void FillTestMap(int characterSize = 12)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                    {
                        tiles[x, y] = new Tile("#", new Vector2(x * characterSize, y * characterSize), Color.White, false);
                    }
                    else
                    {
                        tiles[x, y] = new Tile(".", new Vector2(x * characterSize, y * characterSize), Color.White, true);
                    }
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, SpriteFont font)
        {
            foreach (var t in tiles)
            {
                t.Draw(spriteBatch, font);
            }
        }
    }
}
