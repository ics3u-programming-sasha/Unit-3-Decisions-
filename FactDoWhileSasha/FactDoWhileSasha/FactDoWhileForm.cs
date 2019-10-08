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
            double fact = 1;
            double factTotal = 1;
            double uValue; 

            // convert the string from the text box to a double
            uValue = double.Parse(txtValue.Text);

            // perform the factorial calculation until the factorial value equals the number the user entered
            do
            {
                // multiply the total by the factorial variable 
                factTotal = factTotal * fact;
                // increase the factoriale variable by 1 each time 
                fact = fact + 1;

            } while (fact <= uValue);

            // display the user's value with a factorial sign and the total with its respective answer 
            this.lblAnswer.Text = this.txtValue.Text + "! = " + Convert.ToString(factTotal); 
        }
    }
}