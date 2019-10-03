/*
 * Created by: Sasha Malko 
 * Created on: 1-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Number
 * This program allows the user to play a guess my number game. 
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

            //Hide the answer labels
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

            //generate a random number
            Random rnd = new Random();
            random = rnd.Next(MIN_NUM, MAX_NUM);

            //convert the string into an integer
            guess = int.Parse(txtGuess.Text);


            if (guess == random)
            {
                //display that the answer is correct
                lblAnswer.Text = "You guessed correctly!";
                this.lblAnswer.Show();
                picAnswer.Image = Properties.Resources.checkmark;
                this.picAnswer.Show();
            }
            else
            {
                //display that the answer is incorrect
                lblAnswer.Text = "You guessed incorrectly!";
                this.lblAnswer.Show();
                picAnswer.Image = Properties.Resources.red_x;
                this.picAnswer.Show();
            }
        }
    }
}
