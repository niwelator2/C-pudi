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
    public partial class RadioForm : Form
    {
        public RadioForm()
        {
            InitializeComponent();

            this.Text = "GroupBoxForm";
            this.Width = 800;
            this.Height = 600;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // GroupBox 1: Gender selection
            GroupBox firstGroupBox = new GroupBox();
            firstGroupBox.Location = new Point(12, 12);
            firstGroupBox.Name = "firstGroupBox";
            firstGroupBox.Text = "Select Gender";
            firstGroupBox.Width = 250;
            firstGroupBox.Height = 160;
            firstGroupBox.Padding = new Padding(10);

            // RadioButton for Women
            RadioButton radioButton1 = new RadioButton();
            radioButton1.Location = new Point(20, 30);
            radioButton1.Name = "radioButtonNo1";
            radioButton1.Text = "Kobieta #1";
            radioButton1.Width = 200;
            radioButton1.Height = 35;
            radioButton1.Click += new EventHandler(radioButton1_Click);
            firstGroupBox.Controls.Add(radioButton1);

            // RadioButton for Men
            RadioButton radioButton2 = new RadioButton();
            radioButton2.Location = new Point(20, 65);
            radioButton2.Name = "radioButtonNo2";
            radioButton2.Text = "Mężczyzna #1";
            radioButton2.Width = 200;
            radioButton2.Height = 35;
            radioButton2.Click += new EventHandler(radioButton2_Click);
            firstGroupBox.Controls.Add(radioButton2);

            // Add first group box to the form
            Controls.Add(firstGroupBox);
            // GroupBox 2: Nationality selection
            GroupBox secondGroupBox = new GroupBox();
            secondGroupBox.Location = new Point(50, 180);
            secondGroupBox.Name = "secondGroupBox";
            secondGroupBox.Text = "Select Nationality";
            secondGroupBox.Width = 250;
            secondGroupBox.Height = 180;
            secondGroupBox.Padding = new Padding(10);

            // RadioButton for Polish nationality
            RadioButton polishRadioButton = new RadioButton();
            polishRadioButton.Location = new Point(20, 30);
            polishRadioButton.Name = "polishRadioButton";
            polishRadioButton.Text = "Polish";
            polishRadioButton.Width = 200;
            polishRadioButton.Height = 30;
            polishRadioButton.Click += new EventHandler(polishRadioButton2);
            secondGroupBox.Controls.Add(polishRadioButton);

            // RadioButton for American nationality
            RadioButton americanRadioButton = new RadioButton();
            americanRadioButton.Location = new Point(20, 60);
            americanRadioButton.Name = "americanRadioButton";
            americanRadioButton.Text = "American";
            americanRadioButton.Width = 200;
            americanRadioButton.Height = 30;
            americanRadioButton.Click += new EventHandler(americanRadioButton2);
            secondGroupBox.Controls.Add(americanRadioButton);

            // RadioButton for French nationality
            RadioButton frenchRadioButton = new RadioButton();
            frenchRadioButton.Location = new Point(20, 90);
            frenchRadioButton.Name = "frenchRadioButton";
            frenchRadioButton.Text = "French";
            frenchRadioButton.Width = 200;
            frenchRadioButton.Height = 30;
            frenchRadioButton.Click += new EventHandler(frenchRadioButton2);
            secondGroupBox.Controls.Add(frenchRadioButton);

            // Add second group box to the form
            Controls.Add(secondGroupBox);

            // GroupBox 3: Gender selection with images
            GroupBox genderGroupBox = new GroupBox();
            genderGroupBox.Location = new Point(320, 12);
            genderGroupBox.Name = "genderGroupBox";
            genderGroupBox.Text = "Select Gender with Image";
            genderGroupBox.Width = 450;
            genderGroupBox.Height = 300;
            genderGroupBox.Padding = new Padding(10);
            Controls.Add(genderGroupBox);

            // Panel for "Men" section
            Panel menPanel = new Panel();
            menPanel.Location = new Point(20, 30);
            menPanel.Size = new Size(200, 240);
            menPanel.BorderStyle = BorderStyle.FixedSingle;
            genderGroupBox.Controls.Add(menPanel);

            // PictureBox for Men image
            PictureBox menPictureBox = new PictureBox();
            menPictureBox.Name = "menPictureBox";
            menPictureBox.Location = new Point(10, 10);
            menPictureBox.Size = new Size(180, 180);
            menPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            menPanel.Controls.Add(menPictureBox);

            // RadioButton for Men
            RadioButton manRadioButton = new RadioButton();
            manRadioButton.Location = new Point(50, 200);
            manRadioButton.Name = "manRadioButton";
            manRadioButton.Text = "Men";
            manRadioButton.Width = 100;
            manRadioButton.Height = 30;
            manRadioButton.TextAlign = ContentAlignment.MiddleCenter;
            manRadioButton.Click += (sender, e) => LoadImage("men.jpg", menPictureBox);
            menPanel.Controls.Add(manRadioButton);

            // Panel for "Women" section
            Panel womenPanel = new Panel();
            womenPanel.Location = new Point(230, 30);
            womenPanel.Size = new Size(200, 240);
            womenPanel.BorderStyle = BorderStyle.FixedSingle;
            genderGroupBox.Controls.Add(womenPanel);

            // PictureBox for Women image
            PictureBox womenPictureBox = new PictureBox();
            womenPictureBox.Name = "womenPictureBox";
            womenPictureBox.Location = new Point(10, 10);
            womenPictureBox.Size = new Size(180, 180);
            womenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            womenPanel.Controls.Add(womenPictureBox);

            // RadioButton for Women
            RadioButton womanRadioButton = new RadioButton();
            womanRadioButton.Location = new Point(50, 200);
            womanRadioButton.Name = "womanRadioButton";
            womanRadioButton.Text = "Women";
            womanRadioButton.Width = 100;
            womanRadioButton.Height = 30;
            womanRadioButton.TextAlign = ContentAlignment.MiddleCenter;
            womanRadioButton.Click += (sender, e) => LoadImage("women.png", womenPictureBox);
            womenPanel.Controls.Add(womanRadioButton);
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if(radioButton == null)
            {
                MessageBox.Show("to nie jest radioButton");
                return;
            }
            MessageBox.Show("Kobieta");
            radioButton.Text = "kobieta";
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton == null)
            {
                MessageBox.Show("to nie jest radioButton");
                return;
            }
            MessageBox.Show("Men");
            radioButton.Text = "Men";
        }

        private void polishRadioButton2(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton == null)
            {
                MessageBox.Show("to nie jest radioButton");
                return;
            }
            MessageBox.Show("black");
            radioButton.Text = "pierogi";
        }
        private void americanRadioButton2(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton == null)
            {
                MessageBox.Show("to nie jest radioButton");
                return;
            }
            MessageBox.Show("Oil is a king");
            radioButton.Text = "Oil";
        }
        private void frenchRadioButton2(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton == null)
            {
                MessageBox.Show("to nie jest radioButton");
                return;
            }
            MessageBox.Show("bagieta");
            radioButton.Text = "bagieta";
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
