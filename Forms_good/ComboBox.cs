using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ComboBoxForm
namespace Forms_good
{
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
            this.Text = "ComboBoxForm";
            this.Width = 364;
            this.Height = 162;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // ComboBox 
            System.Windows.Forms.ComboBox comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox1.Size = new Size(300, 21);
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";

            comboBox1.DropDownWidth = 280;
            for(int i = 0; i < 21; i++)
            {
                comboBox1.Items.Add("Item" + i.ToString());
            }
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            this.Controls.Add(comboBox1);

        }
    }
}
