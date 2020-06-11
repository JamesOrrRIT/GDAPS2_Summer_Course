using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonogameTest
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D sidestepper;    //Saves the data for the player's sprite
        Vector2 position;    //Saves the data for the player's position on the screen

        KeyboardState kbState;    //Used to store data for the keyboard state

        SpriteFont mainFont;    //Used to store data for the spritefont

        float playerPositionX;    //Keeps the value of the player's X coordinate
        float playerPositionY;    //Keeps the value of the player's Y coordinate

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
            position = new Vector2(300f, 200);    //This will mark the player's starting coordinates, 300 units right and 200 units down

            this.IsMouseVisible = true;    //Allows the mouse to be seen on screen

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
            sidestepper = Content.Load<Texture2D>("smallCrab");    //Grabs the sprite that represents the player

            mainFont = Content.Load<SpriteFont>("mainFont");    //Grabs the type font for the text
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

            // TODO: Add your update logic here

            //Gets the current keyboard state
            KeyboardState kbState = Keyboard.GetState();

            playerPositionX = position.X;    //Takes the player's X value and saves it
            playerPositionY = position.Y;    //Takes the player's Y value and saves it

            ProcessInput();    //Runs through the input method to update player position constantly

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Goldenrod);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            spriteBatch.Draw(sidestepper, position, Color.White);    //Places the player sprite in the scene

            spriteBatch.DrawString(mainFont, "Hello. My name is James Orr", new Vector2(10, 10), Color.Black);   //Write my name in the top left corner

            spriteBatch.DrawString(mainFont, "X Position : " + playerPositionX, new Vector2(10, 75), Color.Black);    //Writes down the player's current X position
            spriteBatch.DrawString(mainFont, "Y Position : " + playerPositionY, new Vector2(10, 110), Color.Black);    //Writes down the player's current Y position

            spriteBatch.End();

            base.Draw(gameTime);
        }

        private void ProcessInput()
        {
            kbState = Keyboard.GetState();

            if (kbState.IsKeyDown(Keys.Left))    //Pressing down the left button
            {
                position.X -= 2;    //Moves the player left by two units at a time
            }

            if (kbState.IsKeyDown(Keys.Right))    //Pressing down the right button
            {
                position.X += 2;    //Moves the player right by two units at a time
            }

            if (kbState.IsKeyDown(Keys.Up))    //Pressing down the up button
            {
                position.Y -= 2;    //Moves the player up by two units at a time
            }

            if (kbState.IsKeyDown(Keys.Down))    //Pressing down the down button
            {
                position.Y += 2;    //Moves the player down by two units at a time
            }
        }
    }
}
