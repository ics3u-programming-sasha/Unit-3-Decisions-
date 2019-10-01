using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessNumberSasha
{
    public partial class frmGuessNumber : Form
    {
        public frmGuessNumber()
        {
            InitializeComponent();
            this.lblAnswer.Hide();
            this.picAnswer.Hide();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            double guess, random;

            Random rnd = new Random();
            random = rnd.Next(1, 10);

            guess = double.Parse(txtGuess.Text);

            if (guess == random)
            {
                lblAnswer.Text = "You guessed correctly!";
                this.lblAnswer.Show();
                picAnswer.Image = Properties.Resources.checkmark;
                this.picAnswer.Show();
            }
            else
            {
                lblAnswer.Text = "You guessed incorrectly!";
                this.lblAnswer.Show();
                picAnswer.Image = Properties.Resources.red_x;
                this.picAnswer.Show();
            }

        }
    }
}
