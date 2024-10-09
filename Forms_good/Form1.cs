namespace Forms_good
{
    public partial class Form1 : Form
    {
        private TextBox userInput;

        public Form1()
        {
            InitializeComponent();
            this.Text = "My first application";
            this.Width = 800;
            this.Height = 600;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Button 
            Button firstButton = new Button();
            firstButton.Location = new Point(20, 80);
            firstButton.Size = new Size(150, 30);
            firstButton.Text = "Click me";
            firstButton.TextAlign = ContentAlignment.MiddleCenter;
            firstButton.Click += new EventHandler(CheckInput);
            Controls.Add(firstButton);

            // Input TextBox
            userInput = new TextBox();
            userInput.Location = new Point(20, 40);
            userInput.Width = 190;
            Controls.Add(userInput);

            // Label
            Label firstLabel = new Label();
            firstLabel.Location = new Point(20, 14);
            firstLabel.Text = "Enter text:";
            firstLabel.Width = 100;
            Controls.Add(firstLabel);
        }

        private void CheckInput(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userInput.Text))
            {
                MessageBox.Show("Pusto" + MessageBoxButtons.OK+ MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("You entered: " + userInput.Text, "Input Received", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
