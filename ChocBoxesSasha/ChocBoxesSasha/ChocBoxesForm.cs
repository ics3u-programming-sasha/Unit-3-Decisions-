/*
 * Created by: Sasha Malko
 * Created on: 7-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program displays the type of prize the user receives depending on the number of chocolate boxes sold. 
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

namespace ChocBoxesSasha
{
    public partial class frmChocBoxes : Form
    {
        public frmChocBoxes()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declare the local variable
            double number;

            // convert the string from the text box to a double 
            number = double.Parse(txtNumber.Text);

            if (number > 20)
            {
                // display that the user gets a prize
                this.lblPrize.Text = "You get a prize!";
            }

            else if (number < 10)
            {
                // display that the user gets an honorable mention
                this.lblPrize.Text = "You get an honorable mention!";
            }

            else
            {
                // display that the user gets a small prize
                this.lblPrize.Text = "You get a small prize!";
            }
        }
    }
}