/*
 * Created by: Sasha Malko
 * Created on: 9-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Walking Man
 * This program allows for a cartoon man to start walking on the form once the walk button is clicked.
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
// add the following library to use the sleep timer
using System.Threading; 

namespace WalkingManSasha
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void BtnWalk_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            // continue this loop while the frame counter has not reached the max number of frames we have to display
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    // display an image
                    this.picWalkingMan.Image = Properties.Resources.walk1;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 2)
                {
                    // display an image
                    this.picWalkingMan.Image = Properties.Resources.walk2;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 3)
                {
                    // display an image
                    this.picWalkingMan.Image = Properties.Resources.walk3;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 4)
                {
                    // display an image
                    this.picWalkingMan.Image = Properties.Resources.walk4;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 5)
                {
                    // display an image
                    this.picWalkingMan.Image = Properties.Resources.walk5;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 6)
                {
                    // display an image
                    this.picWalkingMan.Image = Properties.Resources.walk6;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 7)
                {
                    // display an image
                    this.picWalkingMan.Image = Properties.Resources.walk7;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 8)
                {
                    // display an image
                    this.picWalkingMan.Image = Properties.Resources.walk8;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 9)
                {
                    // display an image
                    this.picWalkingMan.Image = Properties.Resources.walk9;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else
                {
                    // display an image
                    this.picWalkingMan.Image = Properties.Resources.walk10;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                // refresh the form
                this.Refresh();

                // pause the loop for 100 milliseconds
                Thread.Sleep(100); 
            }
        }
    }
}