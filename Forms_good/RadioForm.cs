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
            genderGroupBox.Width = 250;
            genderGroupBox.Height = 160;
            genderGroupBox.Padding = new Padding(10);

            // RadioButton for Men
            RadioButton manRadioButton = new RadioButton();
            manRadioButton.Location = new Point(20, 30);
            manRadioButton.Name = "manRadioButton";
            manRadioButton.Text = "Men";
            manRadioButton.Width = 200;
            manRadioButton.Height = 40;
            manRadioButton.TextAlign = ContentAlignment.MiddleRight;
            manRadioButton.Click += new EventHandler(imageButto1_Click);
            genderGroupBox.Controls.Add(manRadioButton);

            // RadioButton for Women
            RadioButton womanRadioButton = new RadioButton();
            womanRadioButton.Location = new Point(20, 70);
            womanRadioButton.Name = "womanRadioButton";
            womanRadioButton.Text = "Women";
            womanRadioButton.Width = 200;
            womanRadioButton.Height = 40;
            womanRadioButton.TextAlign = ContentAlignment.MiddleRight;
            womanRadioButton.Click += new EventHandler(imageButto2_Click);
            genderGroupBox.Controls.Add(womanRadioButton);

            // Add gender group box to the form
            Controls.Add(genderGroupBox);
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
            MessageBox.Show("smierc czarnym");
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
        private void imageButto1_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("men.png"))
                {
                    Image ImageToShow = new Bitmap("men.png");
                    ((PictureBox)Controls["pictureBox1"]).Image = (Image)ImageToShow;
                }
                else
                {
                    MessageBox.Show("Plik nie istnieje", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK);
            }
        }
        private void imageButto2_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("women.png"))
                {
                    Image ImageToShow = new Bitmap("women.png");
                    ((PictureBox)Controls["pictureBox1"]).Image = (Image)ImageToShow;
                }
                else
                {
                    MessageBox.Show("Plik nie istnieje", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK);
            }
        }


    }
}
