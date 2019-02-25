using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Screens
{
    public class ScreenManager
    {
        private Stack<IScreen> scenes;

        public ScreenManager()
        {
            scenes = new Stack<IScreen>();
        }

        public void Initialize()
        {
            scenes.Peek().Initialize();
        }

        public void Update(GameTime gameTime)
        {
            scenes.Peek().Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            scenes.Peek().Draw(spriteBatch);
        }

        public void PushScreen(IScreen scene)
        {
            scenes.Push(scene);
        }

        public void PopScreen()
        {
            scenes.Pop();
        }
    }
}
