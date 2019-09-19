using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        // NAME:
        // CLASS AND TERM:
        // PROJECT: Tic Tac Toe

        /* THINGS TO CONSIDER:
            - You must change the project name to conform to the required
              naming convention.
            - You must comment the code throughout.  Failure to do so could result
              in a lower grade.
            - All button names and other provided variables and controls must
              remain the same.  Changing these could result in a 0 on the project.
            - Selecting Blue or Red on the View menu should change the imageList
              attached to all buttons so that any current play will change the color
              of all button images.
            - Saved games should save to XML.  A game should load only from XML and
              should not crash the application if a user tries to load an incorrect 
              file.
        */

        public frmTicTacToe()
        {
            InitializeComponent();
            HandleClientWindowSize();
            blueToolStripMenuItem.Checked = true;//Sets a check on blue as default when game is first loaded
        }

        //Place this inside the class space in the form you would like to size.
        //Call this method AFTER InitializeComponent() inside the form's constructor.
        void HandleClientWindowSize()
        {
            //Modify ONLY these float values
            float HeightValueToChange = 1.4f;
            float WidthValueToChange = 6.0f;

            //DO NOT MODIFY THIS CODE
            int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);
            int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);
            if (height < Size.Height)
                height = Size.Height;
            if (width < Size.Width)
                width = Size.Width;
            this.Size = new Size(width, height);
            this.Size = new Size(376, 720);
        }

        //variables to count turns to go back on forth with the x and o
        int turn = 1;
        int click1 = 0, click2 = 0, click3 = 0, click4 = 0, click5 = 0, click6 = 0, click7 = 0, click8 = 0, click9 = 0;

        //players x and player o variables
        int x = 0;
        int o = 0;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//Exits game when exit is selected from file menu
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //marks a check on red and unchecks blue
            redToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //unchecks red and checks blue
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
        }

        //For the first button, but any button could be clicked first
        private void r1c1button_Click(object sender, EventArgs e)
        {
            //This code is repeated for all buttons on form, only variables with change with for the appropriate button on click count
            if (click1 == 0&& redToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r1c1button.ImageList = redImages;
                    r1c1button.ImageIndex = 0;
                    click1++;
                }
                else
                {
                    r1c1button.ImageList = redImages;
                    r1c1button.ImageIndex = 1;
                    click1++;
                }
                turn++;
            }


            if (click1 == 0 && blueToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r1c1button.ImageList = blueImages;
                    r1c1button.ImageIndex = 0;
                    click1++;
                }
                else
                {
                    r1c1button.ImageList = blueImages;
                    r1c1button.ImageIndex = 1;
                    click1++;
                }
                turn++;
            }

            blueToolStripMenuItem.Enabled = false;
            redToolStripMenuItem.Enabled = false;

            //if (redToolStripMenuItem.Checked==true)
            //{
            //    r1c1button.ImageList = redImages;
            //    r1c1button.ImageIndex = 0;


            //}
            //else if (blueToolStripMenuItem.Checked ==true)
            //{
            //    r1c1button.ImageList = blueImages;
            //    r1c1button.ImageIndex = 0;
            //}

        }

        private void r1c2button_Click(object sender, EventArgs e)
        {

            if (click2 == 0 && redToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r1c2button.ImageList = redImages;
                    r1c2button.ImageIndex = 0;
                    click2++;
                }
                else
                {
                    r1c2button.ImageList = redImages;
                    r1c2button.ImageIndex = 1;
                    click2++;
                }
                turn++;
            }


            if (click2 == 0 && blueToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r1c2button.ImageList = blueImages;
                    r1c2button.ImageIndex = 0;
                    click2++;
                }
                else
                {
                    r1c2button.ImageList = blueImages;
                    r1c2button.ImageIndex = 1;
                    click2++;
                }
                turn++;
            }

            blueToolStripMenuItem.Enabled = false;
            redToolStripMenuItem.Enabled = false;
        }

        private void r1c3button_Click(object sender, EventArgs e)
        {
            if (click3 == 0 && redToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r1c3button.ImageList = redImages;
                    r1c3button.ImageIndex = 0;
                    click3++;
                }
                else
                {
                    r1c3button.ImageList = redImages;
                    r1c3button.ImageIndex = 1;
                    click3++;
                }
                turn++;
            }


            if (click3 == 0 && blueToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r1c3button.ImageList = blueImages;
                    r1c3button.ImageIndex = 0;
                    click3++;
                }
                else
                {
                    r1c3button.ImageList = blueImages;
                    r1c3button.ImageIndex = 1;
                    click3++;
                }
                turn++;
            }
            blueToolStripMenuItem.Enabled = false;
            redToolStripMenuItem.Enabled = false;
        }


        private void r2c1button_Click(object sender, EventArgs e)
        {
            if (click4 == 0 && redToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r2c1button.ImageList = redImages;
                    r2c1button.ImageIndex = 0;
                    click4++;
                }
                else
                {
                    r2c1button.ImageList = redImages;
                    r2c1button.ImageIndex = 1;
                    click4++;
                }
                turn++;
            }


            if (click4 == 0 && blueToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r2c1button.ImageList = blueImages;
                    r2c1button.ImageIndex = 0;
                    click4++;
                }
                else
                {
                    r2c1button.ImageList = blueImages;
                    r2c1button.ImageIndex = 1;
                    click4++;
                }
                turn++;
            }
            blueToolStripMenuItem.Enabled = false;
            redToolStripMenuItem.Enabled = false;
        }
    }
}
