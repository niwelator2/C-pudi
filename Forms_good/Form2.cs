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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Label";
            this.Width = 205;
            this.Height = 145;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            // LinkLabel1   
            LinkLabel linkLabel1 = new LinkLabel();
            linkLabel1.Location = new Point(12, 12);

            linkLabel1.Text = " Google";
            linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel1_LickClicked);

            Controls.Add(linkLabel1);
            // LinkLabel2
            LinkLabel linkLabel2 = new LinkLabel();
            linkLabel2.Location = new Point(9, 42);

            linkLabel2.Text = " Yt";
            linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel2_LickClicked);
            Controls.Add(linkLabel2);

        }

        private void linkLabel1_LickClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "https://www.google.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private void linkLabel2_LickClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "https://www.youtube.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}

