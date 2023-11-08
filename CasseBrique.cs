using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CasseBrique
{
    public class CasseBrique : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Scene SceneMenu;
        SceneMenu MySceneMenu;
        SceneGameplay MySceneGameplay;
        Scene MySceneActual;

        public CasseBrique()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 1100;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            MySceneMenu = new SceneMenu(this);
            MySceneGameplay = new SceneGameplay(this);

            MySceneActual = MySceneMenu;

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                MySceneActual = MySceneGameplay;
            }

            MySceneActual.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            MySceneActual.Draw(_spriteBatch);

            base.Draw(gameTime);
        }
    }
}