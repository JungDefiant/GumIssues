using GumIssues.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameGum;

namespace GumIssues;

public struct GameConfig
{
    public string title;
    public int renderWidth;
    public int renderHeight;
    public int resolutionWidth;
    public int resolutionHeight;
    public bool fullscreen;
}

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private GumService Gum => GumService.Default;

    private DialogueScreen dialog;

    public Game1(GameConfig config)
    {
        _graphics = new GraphicsDeviceManager(this);

        _graphics.PreferredBackBufferWidth = config.resolutionWidth;
        _graphics.PreferredBackBufferHeight = config.resolutionHeight;
        _graphics.PreferredBackBufferFormat = SurfaceFormat.Color;
        _graphics.PreferredDepthStencilFormat = DepthFormat.Depth24Stencil8;
        _graphics.IsFullScreen = config.fullscreen;

        _graphics.ApplyChanges();

        // _renderTarget = new RenderTarget2D(GraphicsDevice, config.renderWidth, config.renderHeight);

        Window.Title = config.title;

        Content = Content;
        Content.RootDirectory = "Content";

        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        Gum.Initialize(this);
        Gum.ContentLoader.XnaContentManager = Content;

        dialog = new DialogueScreen();
        dialog.Show();
        dialog.ButtonContinue.Show();

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here

    }

    protected override void Update(GameTime gameTime)
    {
        if (
            GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
            || Keyboard.GetState().IsKeyDown(Keys.Escape)
        )
            Exit();

        // TODO: Add your update logic here


        Gum.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        Gum.Draw();

        base.Draw(gameTime);

    }
}
