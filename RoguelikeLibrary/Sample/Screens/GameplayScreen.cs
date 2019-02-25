using Library.MapEngine;
using Library.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Screens
{
    public class GameplayScreen : Screen
    {
        private Map map;

        public GameplayScreen(Game game) : base(game)
        {

        }

        public override void Initialize()
        {
            base.Initialize();

            map = new Map(20, 20);
            map.FillTestMap();
        }

        public override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            map.Draw(spriteBatch, menuFont);

            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
