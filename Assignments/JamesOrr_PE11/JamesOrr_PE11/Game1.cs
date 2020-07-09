using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace JamesOrr_PE11
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Used for holding the image
        private Texture2D image;

        //Used for text
        private SpriteFont text;

        //Define the width and height of the screen
        int windowWidth;
        int windowHeight;

        //Counts the number of images drawn
        int imageCount;

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
            windowWidth = graphics.GraphicsDevice.Viewport.Width;
            windowHeight = graphics.GraphicsDevice.Viewport.Height;

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

            image = Content.Load<Texture2D>("sunset");

            text = Content.Load<SpriteFont>("SpriteFont1");

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

            //The recursive method will be called here to draw the original object, taking up the size of the screen
            DrawNeatRecursiveThing(0, 0, windowWidth, windowHeight, Color.White);

            //Text will print out how many images there are on the screen
            spriteBatch.DrawString(text, "Image Count : " + DrawNeatRecursiveThing(0, 0, windowWidth, windowHeight, Color.White), new Vector2(425, 10), Color.Black);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        //The int section is to return the amount of images the method generates
        private int DrawNeatRecursiveThing(int x, int y, int width, int height, Color color)
        {
            //Triggers the draw method that will create the initial image
            spriteBatch.Draw(image, new Rectangle(x, y, width, height), color);

            //The recursion will repeatedly draw the image multiple times until
            //we draw it small enough, lets say when the new image is less than 100 by 75 pixels
            if (width >= 100 && height >= 75)
            {
                //We will call the recursion to create a smaller image in the top left corner,
                //this being twice as small as the original image with the same color
                DrawNeatRecursiveThing(0, 0, width / 2, height / 2, Color.White);

                //And we will call it again to the bottom right corner,
                //this being twice as small as the original with a green color
                DrawNeatRecursiveThing(windowWidth / 2, windowHeight / 2, width / 2, height / 2, Color.ForestGreen);
            }

            //Once the image is small enough, the recursive method will stop and add to the total number of images
            return + 1;    //I couldn't find a way to increment the number in time
        }
    }
}
