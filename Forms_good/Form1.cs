namespace Forms_good
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "My firsy application";
            this.Width = 800;
            this.Height = 600;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Button 
            Button firstButton = new Button();
            firstButton.Location = new Point(20, 19);
            firstButton.Size = new Size(554, 320);

            firstButton.Text = "Clic me";
            Controls.Add(firstButton);
        }
    }
}
