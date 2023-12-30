using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace WinFormsApp1
{
    public partial class RateMoive : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");

        public RateMoive()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you….!!!");

            Displayy f = new Displayy();
            f.Show();
            this.Hide();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you….!!!");

            Displayy f = new Displayy();
            f.Show();
            this.Hide();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you….!!!");

            Displayy f = new Displayy();
            f.Show();
            this.Hide();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you….!!!");

            Displayy f = new Displayy();
            f.Show();
            this.Hide();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you….!!!");

            Displayy f = new Displayy();
            f.Show();
            this.Hide();
        }
    }
}
