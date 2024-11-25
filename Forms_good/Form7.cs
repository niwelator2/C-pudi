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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) 
            {
                string selectedValue = comboBox1.SelectedItem.ToString(); 
                MessageBox.Show($"You selected: {selectedValue}", "Selected Value");
            }
            else
            {
                MessageBox.Show("Please select a value from the ComboBox.", "No Selection");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "";
            message = $"Min: {float.MinValue}, Max: {float.MaxValue}";
            MessageBox.Show(message);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem.ToString();
            string message = "";

            switch (selectedType)
            {
                case "int":
                    message = $"Min: {int.MinValue}, Max: {int.MaxValue}";
                    break;
                case "double":
                    message = $"Min: {double.MinValue}, Max: {double.MaxValue}";
                    break;
                case "char":
                    message = $"Min: {char.MinValue}, Max: {char.MaxValue}";
                    break;
                case "sbyte":
                    message = $"Min: {sbyte.MinValue}, Max: {sbyte.MaxValue}";
                    break;
                default:
                    message = "Unknown type selected.";
                    break;
            }

            MessageBox.Show(message, "Type Information");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
