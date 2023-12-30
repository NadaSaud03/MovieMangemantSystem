namespace WinFormsApp1
{
    partial class Addmoviee
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 83);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 22);
            label3.Name = "label3";
            label3.Size = new Size(27, 25);
            label3.TabIndex = 2;
            label3.Text = "id";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 306);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 3;
            label4.Text = "rating";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 199);
            label5.Name = "label5";
            label5.Size = new Size(41, 25);
            label5.TabIndex = 4;
            label5.Text = "age";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 144);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 5;
            label6.Text = "genre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 257);
            label7.Name = "label7";
            label7.Size = new Size(146, 25);
            label7.TabIndex = 6;
            label7.Text = "short description";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 362);
            label8.Name = "label8";
            label8.Size = new Size(140, 25);
            label8.TabIndex = 7;
            label8.Text = "production date";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "18", "15", "7" });
            comboBox1.Location = new Point(200, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 33);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Comedy", "Romantic", "Action", "Romantic Comedy", "Horror", "Fantisy", "fiction" });
            comboBox2.Location = new Point(197, 136);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 33);
            comboBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 31);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 31);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 31);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(200, 257);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(183, 31);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(197, 362);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(183, 31);
            textBox5.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(340, 399);
            button1.Name = "button1";
            button1.Size = new Size(130, 49);
            button1.TabIndex = 15;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Addmoviee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Addmoviee";
            Text = "Addmoviee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}