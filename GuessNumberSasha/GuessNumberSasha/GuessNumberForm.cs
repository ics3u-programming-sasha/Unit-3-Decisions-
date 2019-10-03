/*
 * Created by: Sasha Malko 
 * Created on: 1-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Number Guessing Game
 * This program allows the user to guess a number between 1 and 10. 
 * If they get it right, a correct image is displayed and a correct sound 
 * is played. If they get it wrong, an X is displayed and an incorrect sound 
 * is played. The number that is generated is random.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberSasha
{
    public partial class frmGuessNumber : Form
    {

        public frmGuessNumber()
        {
            InitializeComponent();

            // hide the answer label and image
            this.lblAnswer.Hide();
            this.picAnswer.Hide();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //declare contstants
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;

            //declare local variables
            int guess, random;

            // generate a random number between the minimum and maximum number
            Random rnd = new Random();
            random = rnd.Next(MIN_NUM, MAX_NUM);

            // convert the string from the text box into an integer
            guess = int.Parse(txtGuess.Text);

            if (guess == random)
            {
                // display that the answer is correct
                lblAnswer.Text = "You guessed correctly!";
                this.lblAnswer.Show();
                // display a correct image
                picAnswer.Image = Properties.Resources.checkmark;
                this.picAnswer.Show();
                // play a correct sound effect
                WMPLib.WindowsMediaPlayer cplayer = new WMPLib.WindowsMediaPlayer();
                cplayer.URL = "Correct Answer Sound Effect.mp3";
                cplayer.controls.play();
            }
            else
            {
                //display that the answer is incorrect
                lblAnswer.Text = "You guessed incorrectly!";
                this.lblAnswer.Show();
                // display an incorrect image
                picAnswer.Image = Properties.Resources.red_x;
                this.picAnswer.Show();
                // play an incorrect sound effect
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.URL = "Wrong Buzzer Sound Effect.mp3";
                wplayer.controls.play();
            }
        }
    }
}