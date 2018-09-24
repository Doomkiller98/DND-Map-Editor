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

namespace DNDMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] filepaths = System.IO.Directory.GetFiles("..\\..\\Images\\Floor");
            foreach (string file in filepaths)
            {
                string filename = file;
                string result = filename.Replace("..\\..\\Images\\Floor\\", "");
                string tileName = result.Replace(".png", "");

                floorCB.Items.Add(tileName);
            }
            string[] filepathsObst = System.IO.Directory.GetFiles("..\\..\\Images\\Obstacle");
            foreach (string file in filepathsObst)
            {
                string filename = file;
                string result = filename.Replace("..\\..\\Images\\Floor\\", "");
                string tileName = result.Replace(".png", "");

                obstaclesCB.Items.Add(tileName);
            }
            floorCB.SelectedIndex = 0;
            obstaclesCB.SelectedIndex = 0;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            gridTable.Controls.Clear();
            int Heigth = Convert.ToInt32(heightNUD.Value);
            int Width = Convert.ToInt32(widthNUD.Value);
            int CurrentHeight = 1;
            int CurrentWidth = 1;

            gridTable.Width = 50 * Width;
            gridTable.Height = 50 * Height;

            while (CurrentHeight <= Heigth)
            {
                CurrentWidth = 1;
                while (CurrentWidth <= Width)
                {
                    PictureBox picture = new PictureBox
                    {
                        Name = "Tile-" + Convert.ToString(CurrentHeight) + "." + Convert.ToString(CurrentWidth),
                        Size = new Size(50, 50),
                        Image = Image.FromFile("..\\..\\Images\\Empty\\border.png"),
                        
                    };
                    picture.Padding = new Padding(0);
                    picture.Margin = new Padding(0);
                    picture.Click += new EventHandler(this.Change);
                    gridTable.Controls.Add(picture);
                    CurrentWidth += 1;
                }
                CurrentHeight += 1;
            }
        }

        private void Change(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            string filePath = picture.ImageLocation;
            if (mapEditRB.Checked == true)
            {
                string floor = floorCB.GetItemText(floorCB.SelectedItem);
                picture.Image = Image.FromFile("..\\..\\Images\\Floor\\"+ floor + ".png");
            }
            if (obstaclesRD.Checked == true && filePath.Contains("\\Empty") == false)
            {
                string Obstacle = obstaclesCB.GetItemText(obstaclesCB.SelectedItem);
                string img1 = "..\\..\\Images\\Obstacle"+ Obstacle + ".png";
                string img2 = filePath;
                string imgCombinedFO =  "..\\..\\Images\\CombinedObstFlr\\" + Obstacle + 
            }

        }
    }
}
