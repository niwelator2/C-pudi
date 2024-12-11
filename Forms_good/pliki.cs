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
    public partial class pliki : Form
    {
        TextBox textFromFile = new TextBox();

        public pliki()
        {
            InitializeComponent();

            this.Text = "OpenFileDialogForm";
            this.Width = 547;
            this.Height = 477;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Input
            textFromFile.Name = "textFromFile";
            textFromFile.Location = new Point(12, 12);
            textFromFile.Width = 500;
            textFromFile.Height = 350;
            textFromFile.Multiline = true; 
            textFromFile.ScrollBars = ScrollBars.Both;
            textFromFile.WordWrap = false;
            Controls.Add(textFromFile);

            // Button
            Button openFileDialogButton = new Button();
            openFileDialogButton.Location = new Point(12, 375);
            openFileDialogButton.Name = "openFileDialogButton1";
            openFileDialogButton.Size = new Size(500, 35);
            openFileDialogButton.TabIndex = 1;
            openFileDialogButton.Text = "Open File ";
            openFileDialogButton.Click += new EventHandler(openFileDialogButton_Click);
            Controls.Add(openFileDialogButton);
        }
        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedFileContent;
                string selectedFilePath;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.Multiselect = false;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedFilePath = openFileDialog.FileName;
                        using (StreamReader reader = new StreamReader(selectedFilePath))
                        {
                            selectedFileContent = reader.ReadToEnd();
                        }
                        textFromFile.Text = selectedFileContent;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
