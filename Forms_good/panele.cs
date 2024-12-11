using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_good
{
    public partial class panele : Form
    {
        public bool chlczydz;
        public panele()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim().ToLower();
            List<string> femaleNames = new List<string> { "anna", "maria", "kasia", "ela", "ewa" };
            List<string> maleNames = new List<string> { "jan", "marek", "adam", "piotr", "krzysztof" };

            if (femaleNames.Contains(name))
            {
                chlczydz = true;
                MessageBox.Show("This is a woman's name.", "Gender Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (maleNames.Contains(name))
            {
                chlczydz = false;
                MessageBox.Show("This is a man's name.", "Gender Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Name not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chlczydz)
            {
                LoadImage("women.png", pictureBox1);
            }
            else
            {
                LoadImage("men.jpg", pictureBox1);
            }
            
        }
        private void LoadImage(string filePath, PictureBox pictureBox)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    pictureBox.Image = new Bitmap(filePath);
                }
                else
                {
                    MessageBox.Show("Image file does not exist: " + filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

    }
}
