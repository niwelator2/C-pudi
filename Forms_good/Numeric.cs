using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_good
{
    public partial class Numeric : Form
    {
        public Numeric()
        {
            InitializeComponent();

            this.Text = "Wybór wieku";
            this.Width = 600;
            this.Height = 200;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            NumericUpDown ageNumericUpDown = new NumericUpDown();
            ageNumericUpDown.Location = new Point(12, 12);
            ageNumericUpDown.Name = "ageNumericUpDown";

            ageNumericUpDown.Width = 500;
            ageNumericUpDown.Height = 25;

            ageNumericUpDown.Minimum = 1;
            ageNumericUpDown.Maximum = 90; 

            ageNumericUpDown.Value = 7; 
            ageNumericUpDown.ValueChanged += new EventHandler(ageNumericUpDown_ValueChanged); 

            Controls.Add(ageNumericUpDown);

            Button submitButton = new Button();
            submitButton.Location = new Point(12, 52);
            submitButton.Text = "Sprawdź wiek";
            submitButton.Height = 35;
            submitButton.Width = 505;

            submitButton.Click += new EventHandler(submitButton_Click);
            Controls.Add(submitButton); 

            TextBox messageTextBox = new TextBox();
            messageTextBox.Name = "messageTextBox"; 
            messageTextBox.Location = new Point(12, 95);
            messageTextBox.Width = 500;
            messageTextBox.Height = 25;
            messageTextBox.ReadOnly = true; 
            Controls.Add(messageTextBox); 
        }

        private void ageNumericUpDown_ValueChanged(object sender, EventArgs e){
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedAge = ((NumericUpDown)Controls["ageNumericUpDown"]).Value;
                string message = "";

                if (selectedAge == 8)
                {
                    message = "Osoba ma 8 lat - czas na komunię!";
                }
                else if (selectedAge == 16)
                {
                    message = "Osoba ma 16 lat - czas na bierzmowanie!";
                }
                else
                {
                    message = $"Osoba ma {selectedAge} lat.";
                }
                ((TextBox)Controls["messageTextBox"]).Text = message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK);
            }
        }
    }
}
