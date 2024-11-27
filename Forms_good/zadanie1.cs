using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Forms_good
{
    public partial class zadanie1 : Form
    {
        private string imie = "";
        private string naz = "";
        public zadanie1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Ensure this radio button is selected and update textBox1 (Imię) accordingly
            if (radioButton1.Checked && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.ToLower(); // Convert text to lowercase
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            imie = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            naz = textBox2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // change letters to small or big in imie 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && !string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = textBox2.Text.ToLower(); // Convert text to lowercase
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && !string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = textBox2.Text.ToUpper(); // Convert text to uppercase
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}