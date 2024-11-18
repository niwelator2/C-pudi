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
    public partial class cw3 : Form
    {
        // GroupBox1
        GroupBox GrupBox1 = new GroupBox();
        // GroupBox2
        GroupBox GrupBox2 = new GroupBox();

        // Label
        Label odp = new Label();

        public cw3()
        {
            InitializeComponent();
            this.Text = "Nacisnij klawisz";
            this.Width = 500;
            this.Height = 400;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            GrupBox1.Location = new Point(15, 10);
            GrupBox1.Text = "Wprowadz Dane";
            GrupBox1.Name = "GrupBox1";
            GrupBox1.Width = 450;
            GrupBox1.Height = 160;
            this.Controls.Add(GrupBox1);

            // GroupBox2
            GroupBox GrupBox2 = new GroupBox();
            GrupBox2.Location = new Point(15, 170);
            GrupBox2.Text = "Wybierz dzialanie";
            GrupBox2.Name = "GrupBox2";
            GrupBox2.Width = 500;
            GrupBox2.Height = 160;
            this.Controls.Add(GrupBox2);

            // Label
            Label label1 = new Label();
            label1.Location = new Point(20, 30);
            label1.Text = "podaj a:";
            label1.Name = "AA";
            label1.Width = 80;
            label1.Height = 200;
            GrupBox1.Controls.Add(label1);

            // Label
            Label label2 = new Label();
            label2.Location = new Point(230, 30);
            label2.Text = "podaj b:";
            label2.Name = "BB";
            label2.Width = 90;
            label2.Height = 200;
            GrupBox1.Controls.Add(label2);

            // Input
            TextBox inputA = new TextBox();
            inputA.Name = "A";
            inputA.Location = new Point(110, 30);
            inputA.Width = 100;
            inputA.Height = 200;
            GrupBox1.Controls.Add(inputA);

            // Input
            TextBox inputB = new TextBox();
            inputB.Name = "B";
            inputB.Location = new Point(320, 30);
            inputB.Width = 100;
            inputB.Height = 200;
            GrupBox1.Controls.Add(inputB);

            // Button
            Button dodawanie = new Button();
            dodawanie.Location = new Point(40, 50);
            dodawanie.Size = new Size(40, 40);
            dodawanie.Text = "+";
            dodawanie.Click += new EventHandler(dodawanie_Click);
            GrupBox2.Controls.Add(dodawanie);

            Button odejmowanie = new Button();
            odejmowanie.Location = new Point(120, 50);
            odejmowanie.Size = new Size(40, 40);
            odejmowanie.Text = "-";
            odejmowanie.Click += new EventHandler(odejmowanie_Click);
            GrupBox2.Controls.Add(odejmowanie);

            Button mnoz = new Button();
            mnoz.Location = new Point(200, 50);
            mnoz.Size = new Size(40, 40);
            mnoz.Text = "*";
            mnoz.Click += new EventHandler(mnoz_Click);
            GrupBox2.Controls.Add(mnoz);

            Button dziel = new Button();
            dziel.Location = new Point(280, 50);
            dziel.Size = new Size(40, 40);
            dziel.Text = "/";
            dziel.Click += new EventHandler(dziel_Click);
            GrupBox2.Controls.Add(dziel);

            Button modulo = new Button();
            modulo.Location = new Point(360, 50);
            modulo.Size = new Size(40, 40);
            modulo.Text = "%";
            modulo.Click += new EventHandler(modulo_Click);
            GrupBox2.Controls.Add(modulo);

            odp.Location = new Point(40, 120);
            odp.Width = 250;
            odp.Height = 80;
            odp.Text = "Wynik";
            odp.Name = "WW";
            GrupBox2.Controls.Add(odp);
        }
        private void dodawanie_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(((TextBox)GrupBox1.Controls["A"]).Text);
            int b = Convert.ToInt16(((TextBox)GrupBox1.Controls["B"]).Text);
            int wynik = a + b;
            MessageBox.Show(wynik.ToString());
            odp.Text = "Wynik to dodawania: " + wynik.ToString();
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(((TextBox)GrupBox1.Controls["A"]).Text);
            int b = Convert.ToInt16(((TextBox)GrupBox1.Controls["B"]).Text);
            int wynik = a - b;
            MessageBox.Show(wynik.ToString());
            odp.Text = "Wynik odejmowania to: " + wynik.ToString();
        }

        private void mnoz_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(((TextBox)GrupBox1.Controls["A"]).Text);
            int b = Convert.ToInt16(((TextBox)GrupBox1.Controls["B"]).Text);
            int wynik = a * b;
            MessageBox.Show(wynik.ToString());
            odp.Text = "Wynik mnożenia to: " + wynik.ToString();
        }

        private void dziel_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(((TextBox)GrupBox1.Controls["A"]).Text);
            int b = Convert.ToInt16(((TextBox)GrupBox1.Controls["B"]).Text);
            int wynik = a / b;
            MessageBox.Show(wynik.ToString());
            odp.Text = "Wynik dzielenia to: " + wynik.ToString();
        }

        private void modulo_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(((TextBox)GrupBox1.Controls["A"]).Text);
            int b = Convert.ToInt16(((TextBox)GrupBox1.Controls["B"]).Text);
            int wynik = a % b;
            MessageBox.Show(wynik.ToString());
            odp.Text = "Wynik modulo to: " + wynik.ToString();
        }
    }
}
