using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics.PerformanceData;
using System.Reflection;

namespace HBAssignment2
{
    public partial class formDesign : Form
    {
        public formDesign()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Clears the tag for the toolbox pb
        /// </summary>
        public void ClearTags()
        {
            pBoxNone.Tag = "";
            pBoxWall.Tag = "";
            pBoxRedDoor.Tag = "";
            pBoxGreenDoor.Tag = "";
            pBoxRedBox.Tag = "";
            pBoxGreenBox.Tag = "";

        }
        /// <summary>
        /// Event handler when a picturebox is clicked it sets the image to the picture box and sets its tag as well
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Picture_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pBox = (PictureBox)sender;
                if (pBoxNone.Tag.ToString() == "none")
                {
                    pBox.Image = null;
                    pBox.Tag = "NONE";
                }
                if (pBoxWall.Tag.ToString() == "wall")
                {
                    pBox.Image = Properties.Resources.wall;
                    pBox.Tag = "WALL";
                }
                if (pBoxRedDoor.Tag.ToString() == "reddoor")
                {
                    pBox.Image = Properties.Resources.red_door;
                    pBox.Tag = "REDDOOR";
                }
                if (pBoxGreenDoor.Tag.ToString() == "greendoor")
                {
                    pBox.Image = Properties.Resources.green_door;
                    pBox.Tag = "GREENDOOR";
                }
                if (pBoxRedBox.Tag.ToString() == "redbox")
                {
                    pBox.Image = Properties.Resources.red_box;
                    pBox.Tag = "REDBOX";
                }
                if (pBoxGreenBox.Tag.ToString() == "greenbox")
                {
                    pBox.Image = Properties.Resources.green_box;
                    pBox.Tag = "GREENBOX";
                }
            }

        }
        /// <summary>
        /// saves the form but first checks each pb on form checks the tag to see if they correspond with the image tag and add to counter and uses savefiledialog to save to pc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSave_Click(object sender, EventArgs e)
        {
            int wallSum = 0;
            int doorSum = 0;
            int boxSum = 0;
            
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {
                switch (pb.Tag)
                {
                    case "WALL":
                        wallSum++;
                        break;
                    case "REDDOOR":
                        doorSum++;
                        break;
                    case "GREENDOOR":
                        doorSum++;
                        break;
                    case "REDBOX":
                        boxSum++;
                        break;
                    case "GREENBOX":
                        boxSum++;
                        break;
                    default:
                        break;
                }
            }
            
            SaveFileDialog qGameDialog = new SaveFileDialog();
            qGameDialog.InitialDirectory = @"C:/";
            qGameDialog.RestoreDirectory = true;
            qGameDialog.FileName = "savegame1";
            qGameDialog.DefaultExt = "txt";
            qGameDialog.Filter = "Text files(*.txt)| *.txt";
            if (qGameDialog.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show("Game Saved Succesfully \n" +"total number of walls" +wallSum + "\n" + "total number of doors:" + doorSum + "\n" + "total number of boxes:" + boxSum);
            }
        }
        /// <summary>
        /// closes menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// takes the rows and columns from user and checks to see if its an int and takes the first coordinates and size and outputs the necessary picture boxes with the different position and name. starts the event when a pb on the toolbox is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtRows.Text, @"^\d+$") && Regex.IsMatch(txtColumn.Text, @"^\d+$"))
            {
                int rows = int.Parse(txtRows.Text);
                int cols = int.Parse(txtColumn.Text);
                int x = 159;
                int y = 90;
                int totalPictureboxes = rows * cols;
                List<PictureBox> pictureboxList = new List<PictureBox>();
                Size size = new Size(70, 60);
                for (int row = 0; row < rows; row++)
                {
                    int curentY = y + row * size.Height;
                    for (int col = 0; col < cols; col++)
                    {
                        int curentX = x + col * size.Width;

                        PictureBox picture = new PictureBox
                        {
                            Name = "pictureBox" + (row + col),
                            Size = size,
                            Location = new Point(curentX, curentY),
                            BorderStyle = BorderStyle.Fixed3D,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Visible = true
                        };
                        picture.Click += new EventHandler(Picture_Click);
                        this.Controls.Add(picture);
                        pictureboxList.Add(picture);


                    }

                }
            }
            else
            {
                MessageBox.Show("Please input only numbers in the textboxes");
            }
        }
        /// <summary>
        /// Clears the tag for each picturebox on the toolbox and sets it again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxNone_Click(object sender, EventArgs e)
        {
            ClearTags();
            pBoxNone.Tag = "none";
        }

        private void pBoxWall_Click(object sender, EventArgs e)
        {
            ClearTags();
            pBoxWall.Tag = "wall";

        }

        private void pBoxRedDoor_Click(object sender, EventArgs e)
        {
            ClearTags();
            pBoxRedDoor.Tag = "reddoor";
        }

        private void pBoxGreenDoor_Click(object sender, EventArgs e)
        {
            ClearTags();
            pBoxGreenDoor.Tag = "greendoor";
        }

        private void pBoxRedBox_Click(object sender, EventArgs e)
        {
            ClearTags();
            pBoxRedBox.Tag = "redbox";
        }

        private void pBoxGreenBox_Click(object sender, EventArgs e)
        {
            ClearTags();
            pBoxGreenBox.Tag = "greenbox";
        }
    }
}
