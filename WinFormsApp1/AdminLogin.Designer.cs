﻿namespace WinFormsApp1
{
    partial class AdminLogin
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(31, 60);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "User name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(40, 141);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(285, 31);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(142, 254);
            button1.Name = "button1";
            button1.Size = new Size(212, 89);
            button1.TabIndex = 4;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(502, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminLogin";
            Text = "AdminLogin";
            Load += AdminLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}