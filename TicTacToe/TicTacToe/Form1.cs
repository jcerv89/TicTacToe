﻿using System;
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
            oToolStripMenuItem.Checked = true;
            //variables to count turns to go back on forth with the x and o
        
        }
        int turn = 1;
        int click1 = 0, click2 = 0, click3 = 0, click4 = 0, click5 = 0, click6 = 0, click7 = 0, click8 = 0, click9 = 0;
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

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xToolStripMenuItem.Checked = true;
            oToolStripMenuItem.Checked = false;
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oToolStripMenuItem.Checked = true;
            xToolStripMenuItem.Checked = false;
        }


        //For the first button, but any button could be clicked first
        private void r1c1button_Click(object sender, EventArgs e)
        {

            //This code is repeated for all buttons on form, only variables with change with for the appropriate button on click count
            if (click1 == 0 && redToolStripMenuItem.Checked == true)
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


            if (click1 == 0 && blueToolStripMenuItem.Checked)
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
            CheckWinner();
            blueToolStripMenuItem.Enabled = false;
            redToolStripMenuItem.Enabled = false;

         

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
            CheckWinner();
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
            CheckWinner();
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
            CheckWinner();
            blueToolStripMenuItem.Enabled = false;
            redToolStripMenuItem.Enabled = false;
        }

      

        private void r2c2button_Click(object sender, EventArgs e)
        {

            if (click5 == 0 && redToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r2c2button.ImageList = redImages;
                    r2c2button.ImageIndex = 0;
                    click5++;
                }
                else
                {
                    r2c2button.ImageList = redImages;
                    r2c2button.ImageIndex = 1;
                    click5++;
                }
                turn++;
            }


            if (click5 == 0 && blueToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r2c2button.ImageList = blueImages;
                    r2c2button.ImageIndex = 0;
                    click5++;
                }
                else
                {
                    r2c2button.ImageList = blueImages;
                    r2c2button.ImageIndex = 1;
                    click5++;
                }
                turn++;
            }
            CheckWinner();
            blueToolStripMenuItem.Enabled = false;
            redToolStripMenuItem.Enabled = false;
        }


        private void r2c3button_Click(object sender, EventArgs e)
        {

            if (click6 == 0 && redToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r2c3button.ImageList = redImages;
                    r2c3button.ImageIndex = 0;
                    click6++;
                }
                else
                {
                    r2c3button.ImageList = redImages;
                    r2c3button.ImageIndex = 1;
                    click6++;
                }
                turn++;
            }


            if (click6 == 0 && blueToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r2c3button.ImageList = blueImages;
                    r2c3button.ImageIndex = 0;
                    click6++;
                }
                else
                {
                    r2c3button.ImageList = blueImages;
                    r2c3button.ImageIndex = 1;
                    click6++;
                }
                turn++;
            }
            CheckWinner();
            blueToolStripMenuItem.Enabled = false;
            redToolStripMenuItem.Enabled = false;
        }

        private void r3c1button_Click(object sender, EventArgs e)
        {
            if (click7 == 0 && redToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r3c1button.ImageList = redImages;
                    r3c1button.ImageIndex = 0;
                    click7++;
                }
                else
                {
                    r3c1button.ImageList = redImages;
                    r3c1button.ImageIndex = 1;
                    click7++;
                }
                turn++;
            }


            if (click7 == 0 && blueToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r3c1button.ImageList = blueImages;
                    r3c1button.ImageIndex = 0;
                    click7++;
                }
                else
                {
                    r3c1button.ImageList = blueImages;
                    r3c1button.ImageIndex = 1;
                    click7++;
                }
                turn++;
            }
            CheckWinner();
            blueToolStripMenuItem.Enabled = false;
            redToolStripMenuItem.Enabled = false;
        }

        private void r3c2button_Click(object sender, EventArgs e)
        {
            if (click8 == 0 && redToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r3c2button.ImageList = redImages;
                    r3c2button.ImageIndex = 0;
                    click8++;
                }
                else
                {
                    r3c2button.ImageList = redImages;
                    r3c2button.ImageIndex = 1;
                    click8++;
                }
                turn++;
            }


            if (click8 == 0 && blueToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r3c2button.ImageList = blueImages;
                    r3c2button.ImageIndex = 0;
                    click8++;
                }
                else
                {
                    r3c2button.ImageList = blueImages;
                    r3c2button.ImageIndex = 1;
                    click8++;
                }
                turn++;
            }
            CheckWinner();

            blueToolStripMenuItem.Enabled = false;
            redToolStripMenuItem.Enabled = false;
        }

        private void r3c3button_Click(object sender, EventArgs e)
        {
            if (click9 == 0 && redToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r3c3button.ImageList = redImages;
                    r3c3button.ImageIndex = 0;
                    click9++;
                }
                else
                {
                    r3c3button.ImageList = redImages;
                    r3c3button.ImageIndex = 1;
                    click9++;
                }
                turn++;
            }


            if (click9 == 0 && blueToolStripMenuItem.Checked == true)
            {
                if (turn % 2 != 0)
                {
                    r3c3button.ImageList = blueImages;
                    r3c3button.ImageIndex = 0;
                    click9++;
                }
                else
                {
                    r3c3button.ImageList = blueImages;
                    r3c3button.ImageIndex = 1;
                    click9++;
                }
                turn++;
            }
            CheckWinner();
            turn = 1;
            click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
            blueToolStripMenuItem.Enabled = false;
            redToolStripMenuItem.Enabled = false;
          

        }


        private void toolStripButtonNewGame_Click(object sender, EventArgs e)
        {
            ClearForm();
   



        }

        public void CheckWinner()
        {
            //Each statement check for 3 in a row, each directiion and each image index on the button.
           
            if (r1c1button.ImageIndex == 0 && r1c2button.ImageIndex==0&&r1c3button.ImageIndex==0)
            {


                MessageBox.Show("O Wins!");
         


            }
            else if (r1c1button.ImageIndex == 1 && r1c2button.ImageIndex == 1 && r1c3button.ImageIndex == 1)
            {
                MessageBox.Show(" X Wins!");
             
            }

           else if (r2c1button.ImageIndex == 0 && r2c2button.ImageIndex == 0 && r2c3button.ImageIndex == 0)
            {
                MessageBox.Show("O Wins!");
                


            }
            else if (r2c1button.ImageIndex == 1 && r2c2button.ImageIndex == 1 && r2c3button.ImageIndex == 1)
            {
                MessageBox.Show(" X Wins!");
                
            }

            else if (r3c1button.ImageIndex == 0 && r3c2button.ImageIndex == 0 && r3c3button.ImageIndex == 0)
            {
                MessageBox.Show("O Wins!");



            }
            else if (r3c1button.ImageIndex == 1 && r3c2button.ImageIndex == 1 && r3c3button.ImageIndex == 1)
            {
                MessageBox.Show(" X Wins!");

            }

           else if (r1c1button.ImageIndex == 0 && r2c1button.ImageIndex == 0 && r3c1button.ImageIndex == 0)
            {
                MessageBox.Show("O Wins!");



            }
            else if (r1c1button.ImageIndex == 1 && r2c1button.ImageIndex == 1 && r3c1button.ImageIndex == 1)
            {
                MessageBox.Show(" X Wins!");

            }

            else if (r3c1button.ImageIndex == 1 && r3c2button.ImageIndex == 1 && r3c3button.ImageIndex == 1)
            {
                MessageBox.Show(" X Wins!");

            }

           else if (r1c2button.ImageIndex == 0 && r2c2button.ImageIndex == 0 && r3c2button.ImageIndex == 0)
            {
                MessageBox.Show("O Wins!");



            }
            else if (r1c2button.ImageIndex == 1 && r2c2button.ImageIndex == 1 && r3c2button.ImageIndex == 1)
            {
                MessageBox.Show(" X Wins!");

            }

           else if (r1c3button.ImageIndex == 0 && r2c3button.ImageIndex == 0 && r3c3button.ImageIndex == 0)
            {
                MessageBox.Show("O Wins!");



            }
            else if (r1c3button.ImageIndex == 1 && r2c3button.ImageIndex == 1 && r3c3button.ImageIndex == 1)
            {
                MessageBox.Show(" X Wins!");

            }

           else if (r1c1button.ImageIndex == 0 && r2c2button.ImageIndex == 0 && r3c3button.ImageIndex == 0)
            {
                MessageBox.Show("O Wins!");



            }
            else if (r1c1button.ImageIndex == 1 && r2c2button.ImageIndex == 1 && r3c3button.ImageIndex == 1)
            {
                MessageBox.Show(" X Wins!");

            }

            else  if (r1c3button.ImageIndex == 0 && r2c2button.ImageIndex == 0 && r3c1button.ImageIndex == 0)
            {
                MessageBox.Show("O Wins!");



            }
            else if (r1c3button.ImageIndex == 1 && r2c2button.ImageIndex == 1 && r3c1button.ImageIndex == 1)
            {
                MessageBox.Show(" X Wins!");

            }
            else if(turn >9)//Checks for a draw in the game
            {
              
                MessageBox.Show("Draw");

            }

         
        }

        private void ClearForm()
        {
            //Resets turn count for new game
            turn = 1;
            click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;

            //Clears buttons of X and O images
            r1c1button.ImageList = null;
            r1c2button.ImageList = null;
            r1c3button.ImageList = null;
            r2c1button.ImageList = null;
            r2c2button.ImageList = null;
            r2c3button.ImageList = null;
            r3c1button.ImageList = null;
            r3c2button.ImageList = null;
            r3c3button.ImageList = null;




            //Resets color view options and re-enables abilty to select red or blue
            blueToolStripMenuItem.Enabled = true;
            blueToolStripMenuItem.Checked = true;
            redToolStripMenuItem.Enabled = true;
            redToolStripMenuItem.Checked = false;

            

        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();

            dlg.DefaultExt = "xml";
            if (DialogResult.OK == dlg.ShowDialog())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.ConformanceLevel = ConformanceLevel.Document;
                settings.Indent = true;

                //Writes to xml doc in xml format
                using (XmlWriter writer = XmlWriter.Create(dlg.FileName, settings))
                {
                    writer.WriteStartElement("Game");
                  //  writer.WriteElementString(r1c1button = this.r1c1button);
                   

                    writer.WriteEndElement();
                }
            }
        }

    }


}

