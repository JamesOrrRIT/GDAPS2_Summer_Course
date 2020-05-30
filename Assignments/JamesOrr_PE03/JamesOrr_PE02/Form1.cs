using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesOrr_PE02
{
    public partial class Form1 : Form
    {
        private int timeCount;    //Tracks the amount of time that passed

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeCount++;

            if (timeCount == 100)    //Triggers the game over sequence if time ran out
            {
                solutionTextBox.Text = "Game Over";    //Changes text in the box
                solutionTextBox.Enabled = false;    //Makes sure the player can't interact with the box afterwards
                timer.Stop();    //Disables the timer
            }

            progressBar.Value = timeCount;    //Regardless, the progress bar will fill up
            timeLeft.Text = "Time Left : " + (100 - timeCount);    //Displays remaining time
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (solutionTextBox.Text == "")    //See if the player entered something in the plan box
            {
                solutionTextBox.Text = "Error : Please enter a plan.";
            }

            else
            {
                timer.Stop();    //Stops timer
                Console.WriteLine("Current Plan : " + solutionTextBox.Text);  //Prints the data in the console window
                Console.WriteLine("Progress Bar Value : " + progressBar.Value);
                Console.WriteLine();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            solutionTextBox.Text = "";    //Clears the current text in the solution box
            solutionTextBox.Enabled = true;    //Re-enables the text box

            timeCount = 0;    //Resets the value of the timer
            progressBar.Value = 0;    //Resets the progress bar
            timer.Start();    //Restarts the timer in case it was disabled
        }
    }
}
