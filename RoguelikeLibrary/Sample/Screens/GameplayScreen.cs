using Library.Entities;
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
        private Camera cam;
        private Player player;
        private Rectangle screenRect;

        public GameplayScreen(Game game) : base(game)
        {

        }

        public override void Initialize()
        {
            base.Initialize();

            screenRect = new Rectangle(((Game1)gameRef).screenRect.Width / 4, 0, 3 * ((Game1)gameRef).screenRect.Width / 4, 3 * ((Game1)gameRef).screenRect.Height / 4);

            map = new Map(100, 100);
            map.FillTestMap();
            cam = new Camera(screenRect);
            player = new Player("@", new Vector2(1, 1), Color.White);
        }

        public override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, null, null, null, transformMatrix: cam.Transformation);
            //((Game1)gameRef).GraphicsDevice.Viewport = new Viewport(screenRect);

            map.Draw(spriteBatch, menuFont);
            player.Draw(spriteBatch, menuFont);

            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            player.Update(gameTime);
            cam.Update(gameTime, player);
        }
    }
}
