/*
 * Created by: Sasha Malko
 * Created on: 8-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program gives the user the answer to the factorial problem they have entered.
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

namespace FactDoWhileSasha
{
    public partial class frmFactDoWhile : Form
    {
        public frmFactDoWhile()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double factorialAnswer = 1;
            double factorialNumber;
            int factorialCounter = 1;

            // clear the items from the listbox
            this.lstFactorialNumbers.Items.Clear();

            // convert the string from the text box to a double
            factorialNumber = double.Parse(txtValue.Text);

            // perform the factorial calculation until the factorial counter equals the number the user entered
            do
            {
                // multiply the factorial answer by the factorial counter
                factorialAnswer = factorialAnswer * factorialCounter;

                // list the counter number in the listbox for the user to see
                this.lstFactorialNumbers.Items.Add(factorialCounter);

                // increase the factorial counter by 1 each time 
                factorialCounter = factorialCounter + 1;

            } while (factorialCounter <= factorialNumber);

            // display the factorial number with a factorial sign equal to the factorial answer
            this.lblAnswer.Text = this.txtValue.Text + "! = " + Convert.ToString(factorialAnswer); 
        }
    }
}