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
            this.Width = 305;
            this.Height = 200;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //GroupBox
            GroupBox firstGroupBox = new GroupBox();
            firstGroupBox.Location = new Point(12, 12);
            firstGroupBox.Name = "firstGroupBox";

            firstGroupBox.Text = "Select Option";

            firstGroupBox.Width = 250;
            firstGroupBox.Height = 120;

            //CheckBox No 1
            RadioButton radioButton1 = new RadioButton();
            radioButton1.Location = new Point(20, 30);
            radioButton1.Name = "radioButtonNo1";
            radioButton1.Text = "Kobieta #1";
            radioButton1.Width = 200;
            radioButton1.Height = 35;
            radioButton1.Click += new EventHandler(radioButton1_Click);
            firstGroupBox.Controls.Add(radioButton1);

            //CheckBox No 2
            RadioButton radioButton2 = new RadioButton();
            radioButton2.Location = new Point(20, 65);
            radioButton2.Name = "radioButtonNo2";
            radioButton2.Text = "Mężczyzna #1";

            radioButton2.Width = 200;
            radioButton2.Height = 35;
            radioButton2.Click += new EventHandler(radioButton2_Click);
            firstGroupBox.Controls.Add(radioButton2);

            Controls.Add(firstGroupBox);
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
    }
}
