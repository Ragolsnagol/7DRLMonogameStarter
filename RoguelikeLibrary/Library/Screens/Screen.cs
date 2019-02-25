using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Library.Screens
{
    public class Screen : IScreen
    {
        protected Game gameRef;
        protected bool hasInitialized = false;
        protected SpriteFont menuFont;

        public bool HasInitialized => hasInitialized;

        public Screen(Game game)
        {
            gameRef = game;
        }
        
        public virtual void Initialize()
        {
            if (!hasInitialized)
            {
                hasInitialized = true;
                LoadContent();
            }
        }

        public virtual void LoadContent()
        {
            // Loads the basic menu font
            menuFont = gameRef.Content.Load<SpriteFont>(@"Fonts/MenuFont");
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }

        public virtual void Update(GameTime gameTime)
        {

        }
    }
}
