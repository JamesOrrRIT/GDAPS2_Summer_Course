using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace MonogameTest
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Random rng = new Random();

        Texture2D player;    //Saves the data for the player's sprite
        Texture2D objectTexture;    //Represents the object that the player can collect

        Rectangle playerPosition;    //Saves the data for the player's position on the screen

        List<Rectangle> movingObjects;    //Make a list that holds multiple rectangle objects

        KeyboardState kbState;    //Used to store data for the keyboard state

        SpriteFont mainFont;    //Used to store data for the spritefont

        float playerPositionX;    //Keeps the value of the player's X coordinate
        float playerPositionY;    //Keeps the value of the player's Y coordinate

        int screenWidth;    //Keeps track of the boundaries of the game screen
        int screenHeight;

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
            playerPosition = new Rectangle(300, 200, 75, 75);    //This will mark the player's starting coordinates, 300 units right and 200 units down, and a size of 75 x 75 pixels

            screenWidth = GraphicsDevice.Viewport.Width;
            screenHeight = GraphicsDevice.Viewport.Height;

            movingObjects = new List<Rectangle>();    //Creates and defines the collection of rectangles we will use as moving objects

            //Creates 5 new rectangles with random coordinates that fit anywhere on the screen
            //They will each fit anywhere on the screen at least 100 pixels away from the borders, so the whole sprite is visible
            //Each will also be 75 pixels wide and 75 pixels tall
            Rectangle moveObject1 = new Rectangle(rng.Next(100, (screenWidth - 100)), rng.Next(100, (screenHeight - 100)), 75, 75);
            Rectangle moveObject2 = new Rectangle(rng.Next(100, (screenWidth - 100)), rng.Next(100, (screenHeight - 100)), 75, 75);
            Rectangle moveObject3 = new Rectangle(rng.Next(100, (screenWidth - 100)), rng.Next(100, (screenHeight - 100)), 75, 75);
            Rectangle moveObject4 = new Rectangle(rng.Next(100, (screenWidth - 100)), rng.Next(100, (screenHeight - 100)), 75, 75);
            Rectangle moveObject5 = new Rectangle(rng.Next(100, (screenWidth - 100)), rng.Next(100, (screenHeight - 100)), 75, 75);

            movingObjects.Add(moveObject1);    //Fills the list of moving objects with the five new Rectangles
            movingObjects.Add(moveObject2);    //so that we can loop through each one quickly
            movingObjects.Add(moveObject3);
            movingObjects.Add(moveObject4);
            movingObjects.Add(moveObject5);

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
            player = Content.Load<Texture2D>("smallCrab");    //Grabs the sprite that represents the player
            objectTexture = Content.Load<Texture2D>("smallCoin");    //Grabs the sprite for the moving object

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

            playerPositionX = playerPosition.X;    //Takes the player's X value and saves it
            playerPositionY = playerPosition.Y;    //Takes the player's Y value and saves it

            //Updates the x and y of every rectangle object
            for (int i = 0; i < movingObjects.Count; i++)
            {
                int rectanglePositionX = movingObjects[i].X;
                int rectanglePositionY = movingObjects[i].Y;

                if (i == 0)    //Constantly tells the first rectangle to move right
                {
                    movingObjects[0] = new Rectangle(rectanglePositionX += 1, rectanglePositionY, movingObjects[0].Width, movingObjects[0].Height);
                }

                if (i == 1)    //Constantly tells the second rectangle to move left
                {
                    movingObjects[1] = new Rectangle(rectanglePositionX -= 1, rectanglePositionY, movingObjects[1].Width, movingObjects[1].Height);
                }

                if (i == 2)    //Constantly tells the third rectangle to move down
                {
                    movingObjects[2] = new Rectangle(rectanglePositionX, rectanglePositionY += 1, movingObjects[2].Width, movingObjects[2].Height);
                }

                if (i == 3)    //Constantly tells the fourth rectangle to move up
                {
                    movingObjects[3] = new Rectangle(rectanglePositionX, rectanglePositionY -= 1, movingObjects[3].Width, movingObjects[3].Height);
                }

                if (i == 4)    //Constantly tells the fifth rectangle to move right and down
                {
                    movingObjects[4] = new Rectangle(rectanglePositionX += 1, rectanglePositionY += 1, movingObjects[4].Width, movingObjects[4].Height);
                }
            }

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

            spriteBatch.Draw(player, playerPosition, Color.White);    //Places the player sprite in the scene

            //Checks if the player is colliding with other ectangles before drawing them
            for (int i = 0; i < movingObjects.Count; i++)
            {
                //If the player is currently intersecting with one of the objects....
                if (playerPosition.Intersects(movingObjects[i]) == true)
                {
                    //The objects will be colored red
                    spriteBatch.Draw(objectTexture, movingObjects[i], Color.Red);
                }

                //If the player isn't intersecting an object....
                else
                {
                    //The objects will retain it's default colors
                    spriteBatch.Draw(objectTexture, movingObjects[i], Color.White);
                }
            }

            /*    //Keeps this entire section out of the code
            spriteBatch.DrawString(mainFont, "Hello. My name is James Orr", new Vector2(10, 10), Color.Black);   //Write my name in the top left corner

            spriteBatch.DrawString(mainFont, "X Position : " + playerPositionX, new Vector2(10, 75), Color.Black);    //Writes down the player's current X position
            spriteBatch.DrawString(mainFont, "Y Position : " + playerPositionY, new Vector2(10, 110), Color.Black);    //Writes down the player's current Y position
            */

            spriteBatch.End();

            base.Draw(gameTime);
        }

        private void ProcessInput()
        {
            kbState = Keyboard.GetState();

            if (kbState.IsKeyDown(Keys.Left))    //Pressing down the left button
            {
                playerPosition.X -= 3;    //Moves the player left by two units at a time
            }

            if (kbState.IsKeyDown(Keys.Right))    //Pressing down the right button
            {
                playerPosition.X += 3;    //Moves the player right by two units at a time
            }

            if (kbState.IsKeyDown(Keys.Up))    //Pressing down the up button
            {
                playerPosition.Y -= 3;    //Moves the player up by two units at a time
            }

            if (kbState.IsKeyDown(Keys.Down))    //Pressing down the down button
            {
                playerPosition.Y += 3;    //Moves the player down by two units at a time
            }
        }
    }
}
