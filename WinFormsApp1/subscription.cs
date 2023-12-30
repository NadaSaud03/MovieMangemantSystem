using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class subscription : Form
    {
        public subscription()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are a member with a Basic subscription,,,Enjoy!!!");
            Main f = new Main();
            f.Show();
            this.Hide();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are a member with a Standerd subscription,,,Enjoy!!!");
            Main f = new Main();
            f.Show();
            this.Hide();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Now you are a member with a Premium subscription,,,Enjoy!!!");
            Main f = new Main();
            f.Show();
            this.Hide();

        }
    }
}
