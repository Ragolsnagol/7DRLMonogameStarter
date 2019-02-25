using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class InputHandler : GameComponent
    {
        //TODO: Add in Mouse support for input

        static KeyboardState keyboardState;
        static KeyboardState lastKeyboardState;

        static MouseState mouseState;
        static MouseState lastMouseState;

        public static KeyboardState KeyboardState => keyboardState;
        public static KeyboardState LastKeyboardState => lastKeyboardState;
        public static MouseState MouseState => mouseState;
        public static MouseState LastMouseState => lastMouseState;

        public InputHandler(Game game) : base(game)
        {
            keyboardState = Keyboard.GetState();
            mouseState = Mouse.GetState();
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            lastKeyboardState = keyboardState;
            keyboardState = Keyboard.GetState();

            lastMouseState = mouseState;
            mouseState = Mouse.GetState();

            base.Update(gameTime);
        }

        public static void FlushKeyboardState()
        {
            lastKeyboardState = keyboardState;
        }

        public static bool KeyReleased(Keys key)
        {
            return keyboardState.IsKeyUp(key) &&
            lastKeyboardState.IsKeyDown(key);
        }

        public static bool KeyPressed(Keys key)
        {
            return keyboardState.IsKeyDown(key) &&
            lastKeyboardState.IsKeyUp(key);
        }

        public static bool KeyDown(Keys key)
        {
            return keyboardState.IsKeyDown(key);
        }

    }
}
