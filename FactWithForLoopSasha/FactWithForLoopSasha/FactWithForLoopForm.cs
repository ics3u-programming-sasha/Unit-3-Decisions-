/*
 * Created by: Sasha Malko
 * Created on: 17-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – #23 – Factorial with For Loop
 * This program calculates the factorial of a number using a for loop. 
 * The 3 parts of the for loop are: Initialization of the counter, the condition, increment/decrement. 
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

namespace FactWithForLoopSasha
{
    public partial class frmFactWithForLoop : Form
    {
        public frmFactWithForLoop()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            double factorialAnswer = 1;
            double factorialNumber;
            int factorialCounter = 1;

            // clear the items from the listbox
            this.lstFactorialNumbers.Items.Clear();

            // convert the string from the text box to a double
            factorialNumber = double.Parse(txtNumber.Text);

            // perform the factorial calculation until the factorial counter equals the number the user entered
            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                // multiply the factorial answer by the factorial counter
                factorialAnswer = factorialAnswer * factorialCounter;

                // list the counter number in the listbox for the user to see
                this.lstFactorialNumbers.Items.Add(factorialCounter);
            } 

            // display the factorial number with a factorial sign equal to the factorial answer
            this.lblFactorialAnswer.Text = this.txtNumber.Text + "! = " + Convert.ToString(factorialAnswer);
        }
    }
}