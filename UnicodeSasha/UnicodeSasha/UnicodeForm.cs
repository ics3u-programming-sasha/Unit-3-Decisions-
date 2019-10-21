/*
 * Created by: Sasha Malko
 * Created on: 21-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
 * This program converts each letter into the number that represents it using unicode.
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

namespace UnicodeSasha
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int counter = 65; 
            string letter; 

            // clear the items in the list box
            this.lstConversions.Items.Clear();

            // perform this loop until the counter is equal to 90
            do
            {
                // convert the counter value into the letter that it represents
                letter = Char.ConvertFromUtf32(counter);

                // display each letter and its number value in the list box
                this.lstConversions.Items.Add(letter + " -> " + Convert.ToString(counter));

                // increase the counter by 1 each time
                counter = counter + 1;

            } while (counter <= 90);
        }
    }
}