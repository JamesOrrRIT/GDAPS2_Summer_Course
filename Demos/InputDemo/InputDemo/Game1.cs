using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace InputDemo
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // demo attributes
        SpriteFont mainFont;
        SpriteFont mouseFont;
        KeyboardState kState;
        MouseState mState;
        GamePadState gState;
        Boolean [] wasd = {false, false, false, false};
        string[] wasdStr = { "W", "A", "S", "D" };

        // variables for frame rate
        int frameRate = 0;
        int frameCount = 0;
        TimeSpan elapsedTime = TimeSpan.Zero;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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
            this.IsMouseVisible = true;  // show mouse cursor in game

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            mainFont = Content.Load<SpriteFont>("mainFont");
            mouseFont = Content.Load<SpriteFont>("SpriteFont1");
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
            // frame rate calculation
            elapsedTime += gameTime.ElapsedGameTime;

            // has a second passed
            if(elapsedTime > TimeSpan.FromSeconds(1))
            {
                elapsedTime -= TimeSpan.FromSeconds(1); // subtract a second
                frameRate = frameCount;
                frameCount = 0;
            }

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            // see if WASD keys are pressed
            kState = Keyboard.GetState();

            if (kState.IsKeyDown(Keys.W)) wasd[0] = true; else wasd[0] = false;
            wasd[1] = kState.IsKeyDown(Keys.A);
            wasd[2] = kState.IsKeyDown(Keys.S);
            wasd[3] = kState.IsKeyDown(Keys.D);

            // deal with the mouse
            mState = Mouse.GetState();

            // get game pad state
            gState = GamePad.GetState(0);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            frameCount++; // starting to draw a new frame

            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            // display a title
            spriteBatch.DrawString(mainFont, "Input Demo", new Vector2(10, 10), Color.Black);

            // check which keys are pressed
            for (int i = 0; i < 4; i++ )
            {
                // if key is pressed display a message
                if(wasd[i] == true)
                {
                    spriteBatch.DrawString(mainFont, wasdStr[i] + " key is pressed",
                        new Vector2(10, (25 * i) + 40), Color.Blue);
                }
            }

            // check for left mouse button press
            if(mState.LeftButton == ButtonState.Pressed)
            {
                spriteBatch.DrawString(mouseFont, "left button on mouse is pressed",
                    new Vector2(mState.X, mState.Y), Color.Red);
            }

            // see some game pad values
            if(gState.IsConnected == false)
            {
                spriteBatch.DrawString(mainFont, "No connected gamepad",
                    new Vector2(10, 200), Color.Black);
            }
            else
            {
                GamePadThumbSticks sticks = gState.ThumbSticks;
                Vector2 left = sticks.Left;
                Vector2 right = sticks.Right;
                string leftStr = "Left thumbstick - X: " + left.X + " Y: " + left.Y;
                string rightStr = "Right thumbstick - X: " + right.X + " Y: " + right.Y;
                spriteBatch.DrawString(mainFont, leftStr, new Vector2(10, 200), Color.Black);
                spriteBatch.DrawString(mainFont, rightStr, new Vector2(10, 230), Color.Black);
            }

            // display framerate
            spriteBatch.DrawString(mainFont, "FPS: " + frameRate,
                new Vector2(400, 10), Color.Magenta);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
