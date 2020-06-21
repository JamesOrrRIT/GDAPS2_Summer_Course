using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesOrr_HW02
{
    class Collectible : GameObject
    {
        //Fields
        private bool active = true;    //Determines if the collectible has intersected with the player, starting active by default

        //Properties
        public bool Active    //Allows us to quickly modify the active state of the collectible
        {
            get { return active; }
            set { active = value; }
        }

        public Collectible (int collectX, int collectY, int collectWidth, int collectHeight)    //Immediately set every state for a GameObject class
            : base (collectX, collectY, collectWidth, collectHeight)
        {
            
        }

        public bool CheckCollision(GameObject checkCollision)
        {
            if (this.Position.Intersects(checkCollision.Position))    //If the collision with the player happens...
            {
                //the method returns true so this particular collectible is disabled
                return true;
            }

            else
            {
                //Otherwise, it will stay false
                return false;
            }
        }

        public override void Draw(SpriteBatch sb)    //A personal draw method
        {
            if (active == true)    //As long as the object is still active....
            {
                base.Draw(sb);    //the item will be drawn on the screen
            }
        }
    }
}
