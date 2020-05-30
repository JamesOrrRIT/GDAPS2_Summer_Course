using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;   // adds SoundPlayer class

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // alarm clock attributes
        private int timeCount; // elapsed time in seconds
        private int timeNeeded; // seconds until alarm goes off
        private int colorCount; // value from 0 - 3
        private Color originalColor; // restore form when done
        private SoundPlayer player; // plays an audio file

        public Form1()
        {
            InitializeComponent();
        }

        // set up the alarm to run
        private void startButton_Click(object sender, EventArgs e)
        {
            timeCount = 0; // reset the elapsed time

            // see how much time we need before the alarm
            //timeNeeded = 20 * 60;
            timeNeeded = 20; // 20 sec delay for testing purposes
            if(min30.Checked)
            {
                timeNeeded = 30 * 60;
            }

            if(min40.Checked)
            {
                timeNeeded = 40 * 60;
            }

            // set up and start the timer
            timer1.Interval = 1000;
            timer1.Start();

            // reset topMost
            this.TopMost = false;

            // set up our sounds
            player = new SoundPlayer();

            // select the audio file
            player.SoundLocation = "C:\\Windows\\Media\\Windows Battery Low.wav";
            player.Load();

            // reset progress bar
            progressBar1.Value = 0;

            // save the background color
            originalColor = this.BackColor;
            colorCount = 0;

            // disable the start button
            startButton.Enabled = false;
        }

        // stop running the alarm
        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // stop the timer

            this.BackColor = originalColor; // restore form color

            player.Stop(); // stop the sound

            // restore the start button
            startButton.Enabled = true;

            progressBar1.Value = 0; // clear progress bar
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCount++; // add a second

            // update the progress bar
            int pct = (timeCount * 100) / timeNeeded; 
            if(pct <= 100)
            {
                progressBar1.Value = pct;
            }

            // does the alarm go off
            if(timeCount >= timeNeeded)
            {
                this.TopMost = true; // force form to the top

                player.PlaySync(); // play the sound file

                // change form background color
                colorCount++;
                colorCount %= 4;
                switch(colorCount)
                {
                    case 0: this.BackColor = Color.CornflowerBlue; break;
                    case 1: this.BackColor = Color.Crimson; break;
                    case 2: this.BackColor = Color.GreenYellow; break;
                    case 3: this.BackColor = Color.MistyRose; break;
                }
            }
        }
    }
}
