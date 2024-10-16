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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Text = " Obliczam ";
            this.Width = 200;
            this.Height = 200;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Label firstLabel1 = new Label();
            firstLabel1.Location = new Point(15, 12);
            firstLabel1.Text = "factorial ! oblicz";
            firstLabel1.Width = 190;
            Controls.Add(firstLabel1);

            TextBox firstInput = new TextBox();
            firstInput.Name = "fractorial";
            firstInput.Location = new Point(250, 12);

            firstInput.Width = 300;
            firstInput.Height = 200;
            Controls.Add((firstInput));

            Label firstLabel2 = new Label();
            firstLabel2.Location = new Point(15, 200);
            firstLabel2.Text = "Eurel";
            firstLabel2.Width = 190;
            Controls.Add(firstLabel2);

            TextBox firstInput2 = new TextBox();
            firstInput2.Name = "fractorial";
            firstInput2.Location = new Point(250, 12);

            firstInput2.Width = 300;
            firstInput2.Height = 200;
            Controls.Add((firstInput2));



            Button button1 = new Button();
            button1.Location = new Point(250, 50);
            button1.Size = new Size(300, 35);
            button1.Text = 'fractional';
            button1.DialogResult = DialogResult.OK;
            button1.Click += new EventHandler(button1_Click);
            Controls.Add(button1)
        }
    }
}
