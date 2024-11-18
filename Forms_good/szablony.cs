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
    public partial class szablony : Form
    {
        public szablony()
        {
            InitializeComponent();
            this.Text = "SplitContainerForm";
            this.MinimizeBox = true;
            this.MaximizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // SplitContainer
            SplitContainer splitContainer1 = new SplitContainer();
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 0;
            splitContainer1.Panel1.BackColor = Color.DarkSeaGreen;
            splitContainer1.Panel1MinSize = 100;

            splitContainer1.Panel2.BackColor = Color.DarkMagenta;
            splitContainer1.Panel2MinSize = 300;

            this.Controls.Add(splitContainer1);
        }
    }
}
