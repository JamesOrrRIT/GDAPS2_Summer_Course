using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesOrr_HW02
{
    class Player : GameObject    //Player is a child class to the GameObject class
    {
        //Fields
        private int levelScore = 0;    //Stores data for the player's score in the current level,
        private int totalScore = 0;    //and the player's score in the whole game, both starting at 0 when the game starts

        //Properties
        public int LevelScore    //Updates the player's level score
        {
            get { return levelScore; }
            set { levelScore = value; }
        }

        public int TotalScore    //Updates the player's total score
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        public Player(int playerX, int playerY, int playerWidth, int playerHeight)
            : base (playerX, playerY, playerWidth, playerHeight)
        {

        }

        public override void Draw(SpriteBatch sb)
        {
            base.Draw(sb);
        }
    }
}
