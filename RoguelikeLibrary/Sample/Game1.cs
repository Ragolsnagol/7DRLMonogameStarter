using Library;
using Library.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sample.Screens;

namespace Sample
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Rectangle screenRect;
        private const int screenWidth = 800;
        private const int screenHeight = 600;
        public const int CHARACTER_SIZE = 16;

        public ScreenManager ScreensManager;
        public MainMenuScreen MainMenu;
        public GameplayScreen GamePlay;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;
            screenRect = new Rectangle(0, 0, screenWidth, screenHeight);

            IsMouseVisible = true;

            Components.Add(new InputHandler(this));

            ScreensManager = new ScreenManager();

            MainMenu = new MainMenuScreen(this);
            GamePlay = new GameplayScreen(this);

            ScreensManager.PushScreen(MainMenu);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            ScreensManager.Initialize();
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            ScreensManager.Update(gameTime);


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            ScreensManager.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}
