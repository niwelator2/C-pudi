namespace Forms_good
{
    partial class RadioButtonForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 300);  // Adjusted to match the form's dimensions in the constructor
            this.Text = "RadioButtonForm";  // Ensuring this matches the form's title in the constructor
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            // Other controls will be added in the constructor of GroupBox.cs
            this.ResumeLayout(false);
        }
    }
}
