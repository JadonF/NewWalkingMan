/*
 * Created by: Jadon F
 * Created on: 14-May-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Dynamic Picture Boxes
 * This program creates dynamic picture boxes.
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
//Add this library
using System.Threading;


namespace NewWalkingMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GeneratePictureBoxes()
        {
            GeneratePicBox(61, 78);
            GeneratePicBox(464, 78);
            GeneratePicBox(61, 358);
            GeneratePicBox(464, 358);
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            GeneratePictureBoxes();
        }

        private void GeneratePicBox(int x, int y)
        {
            //dynamic
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            //location
            tmpPicMan.Location = pntPic;

            //image
            tmpPicMan.Image = Properties.Resources.walk1;

            //stretch
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            //size
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            //click
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            //add
            Controls.Add(tmpPicMan);
        }

        private void PictureBox_Click (object sender, EventArgs e)
        {
            PictureBox tmpPicMan = (PictureBox)sender;

            //Define Variables
            const byte MAX_FRAMES = 10;
            int Counter = 1;

            //Set the loop
            while (Counter < MAX_FRAMES + 1)
            {
                if (Counter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }

                else if (Counter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }

                else if (Counter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }

                else if (Counter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }

                else if (Counter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }

                else if (Counter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }

                else if (Counter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }

                else if (Counter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }

                else if (Counter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }

                else if (Counter == 10)
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                    Counter = 1;
                }

                //Increment the counter
                Counter = Counter + 1;

                //Refresh and set intrevals
                this.Refresh();
                Thread.Sleep(100);
            }

            }



    }
}
