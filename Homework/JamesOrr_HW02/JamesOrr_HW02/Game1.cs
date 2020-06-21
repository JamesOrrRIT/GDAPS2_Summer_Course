using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

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
        int currentLevel = 1;    //The player always starts on level 1
        double timer = 15;    //The timer will always start at 15 seconds
        Random rng = new Random();

        //Identifies the current width and height of the game screen
        int windowWidth;
        int windowHeight;

        //Allows us to create text
        private SpriteFont mainFont;
        private SpriteFont spriteFont;

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
        List<Collectible> collectibleList = new List<Collectible>();

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
            timer = 15;    //Restatrts the timer to 15 seconds when the new level loads
            newPlayer.LevelScore = 0;    //Resets the player's level score

            newPlayer.X = (windowWidth / 2) - 50;    //Resets the player's position to the middle of the screen
            newPlayer.Y = (windowHeight / 2) - 50;

            collectibleList.Clear();    //Clears every item from the collectible list

            for (int i = 0; i < (currentLevel + 1); i++)    //The current number of collectibles is one higher than the level number
            {
                Collectible newItem = new Collectible(rng.Next(10, (windowWidth - 85)), rng.Next(10, (windowHeight - 85)), 75, 75);    //Creates a new collectible

                newItem.Texture = collectibleSprite;    //Apllies the collectibles texture

                collectibleList.Add(newItem);
            }
        }

        private void ResetGame()    //Activates every time the player starts the game from the beginning
        {
            currentLevel = 0;    //Restarts the level counter
            newPlayer.TotalScore = 0;    //Starts the player's total score at 0
            NextLevel();    //Sets up the first level of the game
        }

        private void ScreenWrap()    //Alters player position if the move too far off screen
        {    //Because the player is 100 x 100 pixels, the entire image should be offscreen before wrapping back around
            if (newPlayer.X <= -110)    //If the player moves too far left....
            {
                newPlayer.X = windowWidth;    //they appear from the right side
            }

            if (newPlayer.X >= (windowWidth) + 10)    //If the player moves too far right...
            {
                newPlayer.X = -100;    //they appear from the left side
            }

            if (newPlayer.Y <= -110)    //If the player moves too far up...
            {
                newPlayer.Y = windowHeight;    //they appear from the bottom
            }

            if (newPlayer.Y >= (windowHeight) + 10)    //If the player moves too far down...
            {
                newPlayer.Y = -100;    //they appear from the top
            }
        }

        private bool SingleKeyPress(Keys key, KeyboardState kbState)
        {
            //Makes sure of when a key is pressed once
            if (kbState.IsKeyDown(key) && previousKbState.IsKeyUp(key))
            {
                return true;
            }

            else
            {
                return false;
            }
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
            mainFont = Content.Load<SpriteFont>("mainFont");    //Retrieves the data for the text
            spriteFont = Content.Load<SpriteFont>("SpriteFont1");

            playerSprite = Content.Load<Texture2D>("dragonfly2");    //Retrieves the textures that will be used
            collectibleSprite = Content.Load<Texture2D>("flower");

            newPlayer = new Player((windowWidth / 2) - 50, (windowHeight / 2) - 50, 100, 100);
            newPlayer.Texture = playerSprite;
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
            KeyboardState previousKbState = kbState;

            switch (activeState)
            {
                //Main Menu
                case GameStates.Menu:
                    if (SingleKeyPress(Keys.Enter, kbState) == true)    //Once the player presses the enter key....
                    {
                        activeState = GameStates.Game;    //the screen transitions to the main game
                        ResetGame();    //Resets all data to restart the game
                    }
                    break;

                //Game
                case GameStates.Game:

                    previousKbState = kbState;    //The previous keyboard state will become the current keyboard state
                    kbState = Keyboard.GetState();    //Retrieves the currently pressed keys

                    timer -= gameTime.ElapsedGameTime.TotalSeconds;    //The timer decreases in real time

                    if (kbState.IsKeyDown(Keys.Left) == true)    //Moves the player left
                    {
                        newPlayer.X -= 2;
                    }

                    if (kbState.IsKeyDown(Keys.Right) == true)    //Moves the player right
                    {
                        newPlayer.X += 2;
                    }

                    if (kbState.IsKeyDown(Keys.Up) == true)    //Moves the player up
                    {
                        newPlayer.Y -= 2;
                    }

                    if (kbState.IsKeyDown(Keys.Down) == true)    //Moves the player down
                    {
                        newPlayer.Y += 2;
                    }

                    ScreenWrap();    //Constantly calls the ScreenWrap method if the player strays too far off screen

                    for (int i = 0; i < collectibleList.Count; i++)    //Check every collectible inside the list
                    {
                        if (collectibleList[i].CheckCollision(newPlayer) == true && collectibleList[i].Active == true)    //Once the player collides with the object....
                        {
                            collectibleList[i].Active = false;    //that collectible alone will become inactive
                            newPlayer.LevelScore += 1;    //Increments the player's level score
                            newPlayer.TotalScore += 1;    //Increments the player's total score
                        }
                    }

                    if (timer <= 0)    //Once the timer hits 0....
                    {
                        activeState = GameStates.GameOver;    //the game will transition to the game over screen
                    }

                    if (newPlayer.LevelScore == collectibleList.Count)
                    {
                        NextLevel();
                    }

                    break;

                //Game Over
                case GameStates.GameOver:

                    if (SingleKeyPress(Keys.Enter, kbState) == true)    //Once the player presses the enter key here....
                    {
                        activeState = GameStates.Menu;    //the game will restart
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
                    GraphicsDevice.Clear(Color.CornflowerBlue);    //The background color will be blue on this screen

                    spriteBatch.DrawString(mainFont, "Dragonfly Flight", new Vector2((windowWidth / 3) + 50, windowHeight / 3), Color.Black);    //The main title of the game

                    spriteBatch.DrawString(spriteFont, "Welcome to Dragonfly Flight!", new Vector2(windowWidth / 6, windowHeight / 2), Color.Black);    //Introduces the player and tells them the controls
                    spriteBatch.DrawString(spriteFont, "You will control a Dragonfly and collect the Flowers.", new Vector2(windowWidth / 6, (windowHeight / 2) + 20), Color.Black);
                    spriteBatch.DrawString(spriteFont, "Press the up, down, left, and right buttons to move.", new Vector2(windowWidth / 6, (windowHeight / 2) + 40), Color.Black);
                    spriteBatch.DrawString(spriteFont, "Be sure to collect every flower before running out of time to advance.", new Vector2(windowWidth / 6, (windowHeight / 2) + 60), Color.Black);
                    spriteBatch.DrawString(mainFont, "Press ENTER to start the game", new Vector2((windowWidth / 3) - 50, (windowHeight / 4) * 3), Color.Black);

                    break;

                case GameStates.Game:
                    GraphicsDevice.Clear(Color.LightYellow);    //The background color will be yellow on this screen

                    newPlayer.Draw(spriteBatch);    //Draws the player on the screen

                    for (int i = 0; i < collectibleList.Count; i++)    //For every collectible in the list....
                    {
                        collectibleList[i].Draw(spriteBatch);    //the item will be drawn onto the screen
                    }

                    spriteBatch.DrawString(spriteFont, "Level : " + currentLevel, new Vector2(10, 10), Color.Black);    //Creates each section of the HUD
                    spriteBatch.DrawString(spriteFont, "Level Score : " + newPlayer.LevelScore, new Vector2(10, 30), Color.Black);
                    spriteBatch.DrawString(spriteFont, "Time Left : " + String.Format("{0:0.00}", timer), new Vector2(10, 50), Color.Black);
                    //Writing each of these last will place them over the game objects and not obstruct the view od the HUD

                    break;

                case GameStates.GameOver:
                    GraphicsDevice.Clear(Color.Red);    //The background color will be red on this screen

                    spriteBatch.DrawString(mainFont, "GAME OVER", new Vector2((windowWidth / 3) + 50, windowHeight / 3), Color.White);    //Displays the game over text

                    spriteBatch.DrawString(spriteFont, "You reached Level : " + currentLevel, new Vector2(windowWidth / 3, windowHeight / 2), Color.White);    //Text that displays the player's progress
                    spriteBatch.DrawString(spriteFont, "Your End Score is : " + newPlayer.TotalScore, new Vector2(windowWidth / 3, (windowHeight / 2) + 20), Color.White);

                    spriteBatch.DrawString(mainFont, "Press ENTER to return to the menu", new Vector2(windowWidth / 5, (windowHeight / 3) * 2), Color.White);    //Text that tells the player how to restart the game

                    break;
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
