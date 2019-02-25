﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sample.Screens
{
    public class MainMenuScreen : Screen
    {
        public MainMenuScreen(Game game) : base(game)
        {

        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.DrawString(menuFont, "Test", new Vector2(100, 100), Color.White);

            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {

        }
    }
}
