/*
 * Created by: Sasha Malko
 * Created on: 30-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Temperature Converter
 * This program gets the degrees Celsius from the user, passes it BY VALUE to a procedure 
 * that converts it to Fahrenheit, and then inside the procedure displays the degrees Fahrenheit in a message box. 
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

namespace TempConverterSasha
{
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
        }

        //Function: Calculatetemp
        //Input: double celsius
        //Output: void
        //Description: This function takes the degrees Celsius passed by value and displays a message box with the conversion of Celsius to Fahrenheit
        public void CalculateTemp(Double celsius)
        {
            // declare local variable
            Double fahrenheit;

            // convert the string in the text box to a double
            celsius = double.Parse(txtCelsius.Text);

            // calculate the conversion of degrees Celsius into Fahrenheit
            fahrenheit = (double)9 / (double)5 * celsius + 32;

            // display a message box with the conversion of Celsius to Fahrenheit
            MessageBox.Show(celsius + " degree Celsius = " + fahrenheit + "degrees Fahrenheit");
        }
        private void BtnConvert_Click(object sender, EventArgs e)
        {
            // declare local variables
            Double userCelsius;

            // convert the string in the text box to a double
            userCelsius = Convert.ToDouble(txtCelsius.Text);

            // call the funtion to calculate the conversion passing the userCelsius argument by value
            this.CalculateTemp(userCelsius); 
        }
    }
}
