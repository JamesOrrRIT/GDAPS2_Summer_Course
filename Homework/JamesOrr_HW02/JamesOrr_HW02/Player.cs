using Microsoft.Xna.Framework;
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
        private int levelScore;    //Stores data for the player's score in the current level,
        private int totalScore;    //and the player's score in the whole game

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
    }
}
