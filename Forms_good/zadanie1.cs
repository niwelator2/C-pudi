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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            imie = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            naz = textBox2.Text;
        }
        // imie nr1 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.ToLower(); // Convert text to lowercase for Imię
            }
        }

        // Imie nr2
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.ToUpper(); // Convert text to uppercase for Imię
            }
        }
        // Nazwisko nr1
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && !string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = textBox2.Text.ToLower();
            }
        }
        //Nazwisko nr 2 
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && !string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = textBox2.Text.ToUpper();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
            else
            {
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
            }
        }
    }
}