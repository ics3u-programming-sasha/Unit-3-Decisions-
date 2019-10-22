/*
 * Created by: Sasha Malko
 * Created on: 22-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #25 - Control Objects
 * This program has multiple different Control Objects and changes some property for each type of control object when clicked.
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

namespace ControlObjectsSasha
{
    public partial class frmControlObjects : Form
    {
        public frmControlObjects()
        {
            InitializeComponent();
        }

        private void BtnColour_Click(object sender, EventArgs e)
        {
            // loop through each object on the form and make it green
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Green;

                // if the object is a label, make it purple
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Purple;
                }

                // if the object is a list box, make it red
                if (aControlObject.GetType() == typeof(ListBox))
                {
                    aControlObject.BackColor = Color.Red;
                }
            }
        }

        private void LblColour_Click(object sender, EventArgs e)
        {
            // loop through each object on the form and make it yellow
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Yellow;

                // if the object is a label, make it orange
                if (aControlObject.GetType() == typeof(Button))
                {
                    aControlObject.BackColor = Color.Orange;
                }

                // if the object is a list box, make it blue
                if (aControlObject.GetType() == typeof(ListBox))
                {
                    aControlObject.BackColor = Color.Blue;
                }
            }
        }
    }
}