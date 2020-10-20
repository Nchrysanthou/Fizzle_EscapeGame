using Fizzle_EscapeGame.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Fizzle_EscapeGame.Core
{
    public class Game1 : Game
    {
        private readonly GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private GameStateManager gsm = new GameStateManager();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = Data.ScreenW;
            graphics.PreferredBackBufferHeight = Data.ScreenH;
            graphics.ApplyChanges();


            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            IsMouseVisible = true;
            gsm.Init(Content);
        }
        protected override void Update(GameTime gameTime)
        {
            gsm.Update(gameTime);

            if (Data.Exit == true)
                this.Exit();

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Pink);

            spriteBatch.Begin();
            gsm.Draw(spriteBatch);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
