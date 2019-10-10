/*
 * Created by: Sasha Malko
 * Created on: 10-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect Squares with While Loop
 * This program...
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

            // clear all items from the list box
            this.lstAnswer.Items.Clear();

            // get the user's end value selection from the number up-down box
            endingValue = Convert.ToInt32(this.nudValue.Value);

            while (value <= endingValue)
            {
                squareRootAsDouble = Math.Sqrt(value);

                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                if (squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstAnswer.Items.Add(value + " is a perfect square");
                    this.Refresh();
                }

                value = value + 1; 
            }
        }
    }
}