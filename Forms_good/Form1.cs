namespace Forms_good
{
    public partial class Form1 : Form
    {
        /*public Form1()
        {
            InitializeComponent();
            Form form1 = new Form();
            form1.Text = "My dialog box";
            form1.Width = 600;
            form1.Height = 800;

            Button button1 = new Button();
            Button button2 = new Button();

            button1.Text = "OK";
            button1.Location = new Point(15, 15);
            button1.Size = new Size(200, 100);

            button2.Text = "Cancel";
            button2.Location = new Point(button1.Left, button1.Height + button1.Top + 50);
            button2.Size = new Size(200, 100);

            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;

            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.AcceptButton = button1;
            form1.CancelButton = button2;
            form1.StartPosition = FormStartPosition.CenterScreen;

            form1.Controls.Add(button1);
            form1.Controls.Add(button2);
            form1.ShowDialog();

            if (form1.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("The OK button was clicked");
            }
            else
            {
                MessageBox.Show("The Cancel button was clicked");
            }
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(onExit);
        }
        private void onExit(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacja zostanie zamkniêta!");
        }*/
        public Form1()
        {
            InitializeComponent();

            this.Text = "InputForm";
            this.Width = 347;
            this.Height = 323;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            TextBox firstInput = new TextBox();
            firstInput.Name = "inputBoxInForm";
            firstInput.Location = new Point(12, 12);

            firstInput.Width = 300;
            firstInput.Height = 200;
            firstInput.Multiline = true;
            Controls.Add(firstInput);

            Button firstButton = new Button();

            firstButton.Location = new Point(12, 222);

            firstButton.Text = "Click me!";
            firstButton.Height = 35;
            firstButton.Width = 300;

            firstButton.Click += new EventHandler(firstButton_Click);
            Controls.Add(firstButton);
        }
        private void firstButton_Click(object sender, EventArgs e)
        {
            string ValueOfField = ((TextBox)Controls["inputBoxInForm"]).Text;
            if (ValueOfField == "")
            {
                MessageBox.Show("Field empty!", "Alert!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(ValueOfField, " Alert!", MessageBoxButtons.OK);
            }
        }
    }
}
}
