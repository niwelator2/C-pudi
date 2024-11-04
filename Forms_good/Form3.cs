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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Text = "CHeckBoxForm";
            this.Width = 300;
            this.Height = 217;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // CheckBox 1 
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Location = new Point(12, 12);
            checkBox1.Name = "checkBoxNo1";
            checkBox1.Text = " Some option #1";

            checkBox1.Width = 200;

            Controls.Add(checkBox1);

            // CheckBox 2 
            CheckBox checkBox2 = new CheckBox();
            checkBox2.Location = new Point(12, 42);
            checkBox2.Name = "checkBoxNo2";
            checkBox2.Text = " Some option #2";

            checkBox2.Width = 200;
            checkBox2.Checked = true;

            Controls.Add(checkBox2);

            // CheckBox 3 
            CheckBox checkBox3 = new CheckBox();
            checkBox3.Location = new Point(12, 73);
            checkBox3.Name = "checkBoxNo3";
            checkBox3.Text = " Some option #3";

            checkBox3.Width = 200;

            Controls.Add(checkBox3);

            // Button 
            Button firstButton = new Button();
            firstButton.Location = new Point(12, 110);
            firstButton.Text = "Get values";

            firstButton.Width = 250;
            firstButton.Height = 35;

            firstButton.Click += new EventHandler(firstButton_Click);
            Controls.Add(firstButton);
        }
        private void firstButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fieldNo1Status;
                string fieldNo2Status;
                string fieldNo3Status;

                if (((CheckBox)Controls["checkBoxNo1"]).Checked)
                {
                    fieldNo1Status = "Checked";
                }
                else
                {
                    fieldNo1Status = "Uncheckd";
                }
                if (((CheckBox)Controls["checkBoxNo2"]).Checked)
                {
                    fieldNo2Status = "Checked";
                }
                else
                {
                    fieldNo2Status = "Uncheckd";
                }
                if (((CheckBox)Controls["checkBoxNo3"]).Checked)
                {
                    fieldNo3Status = "Checked";
                }
                else
                {
                    fieldNo3Status = "Uncheckd";
                }
                string Info = "Field status:\n";
                Info += " Field 1 is: " + fieldNo1Status + "\n";
                Info += " Field 2 is: " + fieldNo2Status + "\n";
                Info += " Field 3 is: " + fieldNo3Status + "\n";

                MessageBox.Show(Info, "Status", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}