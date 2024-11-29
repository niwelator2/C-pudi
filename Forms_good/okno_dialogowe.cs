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
    public partial class okno_dialogowe : Form
    {
        public okno_dialogowe()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okno_dialogowe_LocationChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "x: " + this.Left.ToString() + "; y:" + this.Top.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + System.Environment.NewLine
                + "x: " + this.Left.ToString() + "; y: " + this.Top.ToString(), "Komunikat",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
