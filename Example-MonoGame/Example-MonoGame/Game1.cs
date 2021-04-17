using Example_MonoGame.MonoGameAdapter;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using UnityEngineAdapter;

namespace Example_MonoGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

		private UnityEngineMainHandler mainHandler;

		MonoGameRenderer monoGameRenderer;
		XnaInput inputModule;

		public Game1()
        {
			
			graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
			graphics.PreferredDepthStencilFormat = Microsoft.Xna.Framework.Graphics.DepthFormat.Depth24Stencil8;
			graphics.ApplyChanges();




		}

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
			this.IsMouseVisible = true;
			this.Window.AllowUserResizing = true;



			//------ MY CODE ------
			mainHandler = new UnityEngineMainHandler();

			var exporter = new ExportImport();

			var vv = exporter.JsonDeserialize(UIJsonData.data);

			var g = exporter.Deserialize(vv, mainHandler.main.transform);
			UnityEngine.GameObject eventSystem = new UnityEngine.GameObject("EventSystem");
			eventSystem.transform.parent = mainHandler.main.transform;
			var v = eventSystem.AddComponent<UnityEngine.EventSystems.EventSystem>();
			var baseInput = eventSystem.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();
			inputModule = eventSystem.AddComponent<XnaInput>();
			inputModule.Init(this);
			baseInput.inputOverride = inputModule;
			// SUPER IMPORTANT
			UnityEngine.Cursor.visible = true;
			UnityEngine.Cursor.lockState = UnityEngine.CursorLockMode.None;

			// Starts and Awakes all scripts
			mainHandler.Start();

		}

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
			monoGameRenderer = new MonoGameRenderer(this, graphics, Content);

			//eventSystem.transform.parent = main.transform;

			// TODO: use this.Content to load your game content here
		}

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


			inputModule.Tick();
			mainHandler.Update();
			

			// TODO: Add your update logic here

			base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

			mainHandler.ScreenHeight = Window.ClientBounds.Height;
			mainHandler.ScreenWidth = Window.ClientBounds.Width;

			spriteBatch.Begin();
			// TODO: Add your drawing code here
			monoGameRenderer.Draw(spriteBatch, mainHandler.main);
			spriteBatch.End();

			base.Draw(gameTime);
        }
    }
}
