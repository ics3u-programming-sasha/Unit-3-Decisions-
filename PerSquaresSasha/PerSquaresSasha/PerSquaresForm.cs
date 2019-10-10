/*
 * Created by: Sasha Malko
 * Created on: 10-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect Squares with While Loop
 * This program gives the user the perfect squares for the value they have entered. 
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

namespace PerSquaresSasha
{
    public partial class frmPerSquares : Form
    {
        public frmPerSquares()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            // set the intital value
            value = 1;

            // clear all items from the listbox
            this.lstAnswer.Items.Clear();

            // get the user's end value selection from the number up-down box
            endingValue = Convert.ToInt32(this.nudValue.Value);

            // continue stating any perfect squares between the minimum value and the user's selected end value
            while (value <= endingValue)
            {
                // take the square root of the value
                squareRootAsDouble = Math.Sqrt(value);

                // convert the double to an integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                // the only way for the decimal and the integer to be equal is if the value was a perfect square
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    //  display the perfect squares in the listbox
                    this.lstAnswer.Items.Add(value + " is a perfect square");

                    // refresh the form
                    this.Refresh();
                }

                // increase the value by one
                value = value + 1; 
            }
        }
    }
}