namespace Forms_good
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(350, 44);
            button1.Name = "button1";
            button1.Size = new Size(167, 23);
            button1.TabIndex = 0;
            button1.Text = "Zwróć rozmiar z ComboBox";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(56, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Rozmiar";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(350, 251);
            button2.Name = "button2";
            button2.Size = new Size(167, 23);
            button2.TabIndex = 2;
            button2.Text = "Zamknij";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(45, 251);
            button3.Name = "button3";
            button3.Size = new Size(172, 23);
            button3.TabIndex = 3;
            button3.Text = "Zwróć rozmiar typu float";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.On;
            comboBox1.Items.AddRange(new object[] { "char", "int", "double", "sbyte" });
            comboBox1.Location = new Point(45, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(350, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 5;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private TextBox textBox2;
    }
}