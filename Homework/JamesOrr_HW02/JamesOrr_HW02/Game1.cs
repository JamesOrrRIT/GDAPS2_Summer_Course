using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace JamesOrr_HW02
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    /// 
    enum GameStates
    {
        Menu,    //The initial menu that tells the user the objective and controls
        Game,    //The state in which the player actually plays the game to move and collect objects under a time limit
        GameOver    //The state where the player runs out of time with instructions to return to the main menu
    }

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Counts the current level, remaining time, and a random number to determine coordinates
        int currentLevel;
        double timer = 15;
        Random rng = new Random();

        //Identifies the current width and height of the game screen
        int windowWidth;
        int windowHeight;

        //Allows us to create text
        private SpriteFont arial12;

        //Textures used for the player and collectible objects
        private Texture2D playerSprite;
        private Texture2D collectibleSprite;

        //Tracks keyboard input
        KeyboardState kbState;
        KeyboardState previousKbState;

        //Identifies the current state that the game is in, starting in the menu
        GameStates activeState = GameStates.Menu;

        //Creates the player and collectibles
        Player newPlayer;

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
            windowWidth = graphics.GraphicsDevice.Viewport.Width;    //Defines the width of the window
            windowHeight = graphics.GraphicsDevice.Viewport.Height;    //Defines the height of the window

            base.Initialize();
        }

        private void NextLevel()    //Will trigger every time the player moves to the next level of the game
        {
            currentLevel += 1;    //Increases the level count by one
            timer = 20;    //Restatrts the timer to 20 seconds when the new level loads
        }

        private void ResetGame()    //Activates every time the player starts the game from the beginning
        {
            currentLevel = 0;    //Restarts the level counter
            newPlayer.TotalScore = 0;    //Starts the player's total score at 0
            NextLevel();    //Sets up the first level of the game
        }

        private void ScreenWrap()    //Alters player position if the move too far off screen
        {

        }

        private bool SingleKeyPress(Keys key, KeyboardState currentKeyboardState)
        {
            if (currentKeyboardState.IsKeyDown(key) && previousKbState.IsKeyUp(key))
            {
                return true;
            }

            return false;
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
            KeyboardState kbState = Keyboard.GetState();
            KeyboardState previousKbState;

            switch (activeState)
            {
                //Main Menu
                case GameStates.Menu:
                    if (SingleKeyPress(Keys.Enter, kbState) == true)    //Once the player presses the enter key....
                    {
                        activeState = GameStates.Game;    //the screen transitions to the main game
                    }
                    break;

                //Game
                case GameStates.Game:
                    //Updates the counter
                    timer -= 0.016;    //The timer decreases by this amount each time update is called

                    if (timer <= 0)    //Once the timer hits 0....
                    {
                        activeState = GameStates.GameOver;    //the game will transition to the game over screen
                    }

                    break;

                //Game Over
                case GameStates.GameOver:
                    //Engages a complete reset for the timer and scores
                    ResetGame();

                    if (SingleKeyPress(Keys.Enter, kbState) == true)    //Once the player presses the enter key here....
                    {
                        activeState = GameStates.Game;    //The game will restart
                    }

                    break;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            
            switch (activeState)
            {
                case GameStates.Menu:
                    GraphicsDevice.Clear(Color.CornflowerBlue);
                    break;

                case GameStates.Game:
                    GraphicsDevice.Clear(Color.LightYellow);
                    break;

                case GameStates.GameOver:
                    GraphicsDevice.Clear(Color.Red);
                    break;
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
