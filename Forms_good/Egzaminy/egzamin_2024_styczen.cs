using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_good
{
    public partial class egzamin_2024_styczen : Form
    {
        public egzamin_2024_styczen()
        {
            InitializeComponent();

            // Bind events
            textBox1.Leave += TextBox1_Leave;
            button1.Click += button1_Click; 
        }

        private void dane_osoby(object sender, EventArgs e)
        {
            // Gather data
            string numer = textBox1.Text;
            string imię = textBox2.Text;
            string nazwisko = textBox3.Text;
            bool oczy_niebieskie = radioButton1.Checked;
            bool oczy_zielone = radioButton2.Checked;
            bool oczy_piwne = radioButton3.Checked;

            // Display data
            if (oczy_niebieskie)
            {
                MessageBox.Show($"{imię} {nazwisko} ma niebieskie oczy.");
            }
            else if (oczy_zielone)
            {
                MessageBox.Show($"{imię} {nazwisko} ma zielone oczy.");
            }
            else
            {
                MessageBox.Show($"{imię} {nazwisko} ma piwne oczy.");
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                // Adjust path based on your working directory
                string imagePath1 = "Properties\\Image\\111-zdjecie.jpg";
                string imagePath2 = "Properties\\Image\\111-odcisk.jpg";

                pictureBox1.Image = Image.FromFile(imagePath1);
                pictureBox2.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call dane_osoby
            dane_osoby(sender, e);

            try
            {
                // Adjust path based on your working directory
                string imagePath1 = "Properties\\Image\\333-zdjecie.jpg";
                string imagePath2 = "Properties\\Image\\333-odcisk.jpg";

                pictureBox1.Image = Image.FromFile(imagePath1);
                pictureBox2.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}");
            }
        }
    }
}
