using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiniGame
{
    public class MiniGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private int _sirkaOkna = 800;
        private int _vyskaOkna = 600;

        private Ctverecek _ctverecek;
        private Ctverecek2 _ctverecek2;
        private Ctverecek3 _ctverecek3;


        public MiniGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Window.Title = "MiniGame";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = _sirkaOkna;
            _graphics.PreferredBackBufferHeight = _vyskaOkna;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _ctverecek = new Ctverecek(
                50, 5,
                new Vector2((100), (350)),
                new SmeroveOvladani(Keys.A, Keys.D, Keys.W, Keys.S),
                new Rectangle(0, 0, _sirkaOkna, _vyskaOkna),
                Color.Red, GraphicsDevice
            );

            _ctverecek2 = new Ctverecek2(
                50, 5,
                new Vector2((350), (300)),
                new SmeroveOvladani(Keys.J, Keys.L, Keys.I, Keys.K),
                new Rectangle(0, 0, _sirkaOkna, _vyskaOkna),
                Color.Green, GraphicsDevice
            );

            _ctverecek3 = new Ctverecek3(
                50, 5,
                new Vector2((600), (400)),
                new SmeroveOvladani(Keys.Left, Keys.Right, Keys.Up, Keys.Down),
                new Rectangle(0, 0, _sirkaOkna, _vyskaOkna),
                Color.Blue, GraphicsDevice
            );
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState klavesnice = Keyboard.GetState();

            if (klavesnice.IsKeyDown(Keys.Escape))
                Exit();

            _ctverecek.Aktualizovat(klavesnice);
            _ctverecek2.Aktualizovat(klavesnice);
            _ctverecek3.Aktualizovat(klavesnice);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Beige);

            _spriteBatch.Begin();

            _ctverecek.Vykreslit(_spriteBatch);
            _ctverecek2.Vykreslit(_spriteBatch);
            _ctverecek3.Vykreslit(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
