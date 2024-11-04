using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_good
{
    public partial class DateRangePickerForm : Form
    {
        public DateRangePickerForm()
        {
            InitializeComponent();
            this.Text = "Date Range Picker";
            this.Width = 345;
            this.Height = 200;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // dateTimePickerMin (Minimalna data)
            DateTimePicker dateTimePickerMin = new DateTimePicker();
            dateTimePickerMin.Size = new Size(300, 25);
            dateTimePickerMin.Location = new Point(12, 12);
            dateTimePickerMin.Name = "dateTimePickerMin";
            dateTimePickerMin.MinDate = new DateTime(2015, 1, 1);
            dateTimePickerMin.MaxDate = DateTime.Today;
            this.Controls.Add(dateTimePickerMin);

            // dateTimePickerMax (Maksymalna data)
            DateTimePicker dateTimePickerMax = new DateTimePicker();
            dateTimePickerMax.Size = new Size(300, 25);
            dateTimePickerMax.Location = new Point(12, 50);
            dateTimePickerMax.Name = "dateTimePickerMax";
            dateTimePickerMax.MinDate = new DateTime(2015, 1, 1);
            dateTimePickerMax.MaxDate = DateTime.Today;
            this.Controls.Add(dateTimePickerMax);

            // Button Submit
            Button submitButton = new Button();
            submitButton.Size = new Size(300, 30);
            submitButton.Location = new Point(12, 90);
            submitButton.Text = "Submit";
            submitButton.Click += (sender, e) =>
            {
                DateTime minDate = dateTimePickerMin.Value;
                DateTime maxDate = dateTimePickerMax.Value;

                if (minDate > maxDate)
                {
                    MessageBox.Show("Minimalna data nie może być późniejsza niż maksymalna data.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Zakres dat:\nOd: {minDate.ToShortDateString()}\nDo: {maxDate.ToShortDateString()}", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            this.Controls.Add(submitButton);
        }
    }
}
