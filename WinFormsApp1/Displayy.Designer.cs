﻿namespace WinFormsApp1
{
    partial class Displayy
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(812, 327);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Cursor = Cursors.PanNorth;
            button1.Location = new Point(41, 340);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(205, 93);
            button1.TabIndex = 1;
            button1.Text = "Add to my list";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(528, 340);
            button2.Name = "button2";
            button2.Size = new Size(216, 93);
            button2.TabIndex = 2;
            button2.Text = "rate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(641, 444);
            button3.Name = "button3";
            button3.Size = new Size(10, 10);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 4;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 202);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 290);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 6;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 7;
            label4.Text = "Rating";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 160);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 8;
            label5.Text = "Descriptipn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 247);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 9;
            label6.Text = "Genre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 71);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 10;
            label7.Text = "Production Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(459, 31);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(459, 31);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(188, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(459, 31);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(188, 284);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(459, 31);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(188, 157);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(459, 31);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(188, 116);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(459, 31);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(188, 68);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(459, 31);
            textBox7.TabIndex = 17;
            // 
            // button4
            // 
            button4.Location = new Point(287, 340);
            button4.Name = "button4";
            button4.Size = new Size(195, 93);
            button4.TabIndex = 18;
            button4.Text = "Watch ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Displayy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            Controls.Add(button4);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Displayy";
            Text = "Displayy";
            Load += Displayy_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button4;
    }
}