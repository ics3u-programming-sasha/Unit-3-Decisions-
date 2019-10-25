/*
 * Created by: Sasha Malko
 * Created on: 25-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Running Average
 * This program calculates the user's average by constantly accepting inputs (a mark between 0 and 100). 
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

namespace RunningAverageSasha
{
    public partial class frmRunningAverage : Form
    {
        // declare global variables
        double sum = 0, numberOfValues = 0;

        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double average, value;

            // convert the string in the text box to a double 
            value = double.Parse(this.txtNumber.Text);

            // if the value is greater than 100, display a message saying to enter a valid number or -1 to exit
            if (value > 100)
            {
                MessageBox.Show("Please enter a valid number or -1 to exit.", "Running Average");
            }

            // if the user enters -1, display a Goodbye message and disable buttons
            else if (value == -1)
            {
                MessageBox.Show("Running average ended.", "Running Average");
                this.btnCalculate.Enabled = false;
                this.txtNumber.Visible = false;
            }

            // if the value is less than 100, display a message saying to enter a valid number or -1 to exit
            else if (value < 0)
            {
                MessageBox.Show("Please enter a valid number or -1 to exit.", "Running Average");
            }

            // if none of the above are true then
            else
            {
                // increase the number of values variable by 1 each time
                numberOfValues++;

                // set the sum variable equal to the value variable plus the sum variable
                sum = value + sum;

                // calculate the average by dividing the sum variable by the number of values variable
                average = sum / numberOfValues;

                // insert the average into its respective label
                lblAverage.Text = "The running average is: " + String.Format ("{0:0.0}", average);
            }
        }
    }
}