/*
 * Created by: Sasha Malko
 * Created on: 4-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program allows the user to play rock, paper, 
 * scissors with the computer. The computer generates a 
 * selection randomly, and then it states who wins. 
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

namespace RockPaperScissorsSasha
{
    public partial class frmRockPaperScissors : Form
    {
        // declare global variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();
            // create the random number generator object
            randomNumberGenerator = new Random();

            // hide the computer's choice label, winner label, and picture
            this.lblCChoice.Hide();
            this.lblWinner.Hide();
            this.picCChoice.Hide();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // declare constants and local variables
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;
            int computerChoice, playerChoice;

            // get the user's selection, if there is no selection set it to 0
            if (radRock.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
            }

            // randomly generate a number between 1 and 3, representing ROCK, PAPER, or SCISSORS
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE+1);

            // show the computer's choice label, winner label, and picture
            this.lblCChoice.Show();
            this.lblWinner.Show();
            this.picCChoice.Show();

            if (playerChoice == ROCK)
            {
                if (computerChoice == ROCK)
                {
                    // display that it is a tie
                    this.lblCChoice.Text = "The computer's choice is rock.";
                    picCChoice.Image = Properties.Resources.Rock;
                    lblWinner.Text = "It is a tie!";
                }
                else if (computerChoice == PAPER)
                {
                    // display that the computer wins
                    this.lblCChoice.Text = "The computer's choice is paper.";
                    picCChoice.Image = Properties.Resources.Paper;
                    lblWinner.Text = "The computer wins!";
                }
                else if (computerChoice == SCISSORS)
                {
                    // display that the user wins
                    this.lblCChoice.Text = "The computer's choice is scissors.";
                    picCChoice.Image = Properties.Resources.Scissors;
                    lblWinner.Text = "You win!";
                }
            }

            else if (playerChoice == PAPER)
            {
                if (computerChoice == PAPER)
                {
                    // display that it is a tie
                    this.lblCChoice.Text = "The computer's choice is paper.";
                    picCChoice.Image = Properties.Resources.Paper;
                    lblWinner.Text = "It is a tie!";
                }
                else if (computerChoice == ROCK)
                {
                    // display that the user wins
                    this.lblCChoice.Text = "The computer's choice is rock.";
                    picCChoice.Image = Properties.Resources.Rock;
                    lblWinner.Text = "You win!";
                }
                else if (computerChoice == SCISSORS)
                {
                    // display that the computer wins
                    this.lblCChoice.Text = "The computer's choice is scissors.";
                    picCChoice.Image = Properties.Resources.Scissors;
                    lblWinner.Text = "The computer wins!";
                }
            }
            else if (playerChoice == SCISSORS)
            {
                if (computerChoice == SCISSORS) 
                {
                    // display that it is a tie
                    this.lblCChoice.Text = "The computer's choice is scissors.";
                    picCChoice.Image = Properties.Resources.Scissors;
                    lblWinner.Text = "It is a tie!";
                }
                else if (computerChoice == PAPER) 
                {
                    // display that the user wins
                    this.lblCChoice.Text = "The computer's choice is paper.";
                    picCChoice.Image = Properties.Resources.Paper;
                    lblWinner.Text = "You win!";
                }
                else if (computerChoice == ROCK)
                {
                    // display that the computer wins
                    this.lblCChoice.Text = "The computer's choice is rock.";
                    picCChoice.Image = Properties.Resources.Rock;
                    lblWinner.Text = "The computer wins!";
                }
            }
        }
    }
}