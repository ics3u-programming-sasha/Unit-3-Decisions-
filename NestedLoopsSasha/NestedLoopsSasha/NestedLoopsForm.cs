/*
 * Created by: Sasha Malko
 * Created on: 23-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #26 - Nested Loops
 * This program displays all the letters of the alphabet from A to Z 
 * but for each letter, it writes all the letters from a to z beside it. 
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

namespace NestedLoopsSasha
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int letterVal, lowerLetterVal;
            string lowerCase, upperCase;

            // clear the list box 
            this.lstLetters.Items.Clear();

            // perform this loop until the letterVal equals to 90
            for (letterVal = 65; letterVal <= 90; letterVal++)
            {
                // convert the letterVal value into the letter that it represents
                upperCase = Char.ConvertFromUtf32(letterVal);

                // perform this loop until the letterVal equals to 122
                for (lowerLetterVal = 97; lowerLetterVal <= 122; lowerLetterVal++)
                {
                    // convert the lowerLetterVal value into the letter that it represents
                    lowerCase =  Char.ConvertFromUtf32(lowerLetterVal);

                    // display each upper case letter and lower case letter in the list box
                    this.lstLetters.Items.Add(upperCase + " -> " + lowerCase);
                }
            }
        }
    }
}