using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;    //Allow the class to access the objects for a monogame class,
using Microsoft.Xna.Framework.Graphics;    //such as Texture2D and Rectangle

namespace JamesOrr_HW02
{
    class GameObject
    {
        //Fields
        public Rectangle position;    //Keeps track of the GameObject's coordinates and size
        public Texture2D texture;    //Stores value for the image that will represent the GameObject

        //Properties
        public Rectangle Position
        {
            get { return position; }    //Easily helps set up the rectangle data
            set { position = value; }
        }

        public Texture2D Texture
        {
            get { return texture; }    //Easily helps in obtaining the texture
            set { texture = value; }
        }

        //Constructor
        protected GameObject(int xCoordinate, int yCoordinate, int width, int height)
        {
            this.position.X = xCoordinate;    //Retrieves data for the GameObject's rectangle object
            this.position.Y = yCoordinate;
            this.position.Width = width;
            this.position.Height = height;
        }

        public virtual void Draw(SpriteBatch sb)    //The GameObject's own Draw method, can be overriden by child classes
        {
            sb.Draw(texture, position, Color.White);    //The components needed to draw the collectible
        }
    }
}
