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
    public partial class egzamin_2023_czerwiec : Form
    {
        public egzamin_2023_czerwiec()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label4.Text = "Cena: 1zł";
                pictureBox1.Image = Image.FromFile("Properties\\Image\\pocztowka.png");

            }
            else if (radioButton2.Checked == true)
            {
                label4.Text = "List: 1,5zł";
                pictureBox1.Image = Image.FromFile("Properties\\Image\\list.png");
            }
            else if (radioButton3.Checked == true)
            {
                label4.Text = "List: 10zł";
                pictureBox1.Image = Image.FromFile("Properties\\Image\\paczka.png");
            }
        }

        private void valid_data(object sender, EventArgs e) {

            if (textBox2.Text.Length == 0 || textBox2.Text.Length > 5 || textBox2.Text.Length < 5){
                // messagebox if not valid on lenhght
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (!int.TryParse(textBox2.Text, out _))
            {
                // messagebox if not number
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else
            {
                // messagebox if valid
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            valid_data(sender, e);
        }
    }
}
