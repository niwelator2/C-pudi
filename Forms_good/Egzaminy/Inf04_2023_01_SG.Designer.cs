namespace Forms_good.Egzaminy
{
    partial class Inf04_2023_01_SG
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
            groupBox1 = new GroupBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            button1 = new Button();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane pracownika";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            comboBox1.Location = new Point(172, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 123);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Stanowisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 84);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 42);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(388, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 265);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generowanie hasła";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Location = new Point(132, 221);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 4;
            button1.Text = "Generuj hasło";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(39, 179);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(107, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Znaki specialne";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(39, 140);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(54, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Cyfry";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(39, 105);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Małe i wielkie litery";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 39);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "Ile znaków?";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Location = new Point(312, 375);
            button2.Name = "button2";
            button2.Size = new Size(181, 23);
            button2.TabIndex = 2;
            button2.Text = "Zatwierdź";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Inf04_2023_01_SG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Inf04_2023_01_SG";
            Text = "Inf04_2023_01_SG";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label4;
        private Button button2;
        private TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}