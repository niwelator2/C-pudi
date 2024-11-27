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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Update the "imie" field with the text from textBox1
            imie = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Update the naz field whenever the text in textBox2 changes
            naz = textBox2.Text;

            // Apply transformation based on selected radio button
            if (radioButton1.Checked)
            {
                textBox2.Text = naz.ToLower();
                textBox2.SelectionStart = textBox2.Text.Length;
            }
            else if (radioButton2.Checked)
            {
                textBox2.Text = naz.ToUpper();
                textBox2.SelectionStart = textBox2.Text.Length;
            }
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
            if (radioButton1.Checked && !string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = textBox2.Text.ToLower();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && !string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = textBox2.Text.ToUpper();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}