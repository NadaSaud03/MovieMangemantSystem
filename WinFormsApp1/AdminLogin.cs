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
    public partial class AdminLogin : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("Select * from Admindb where userName='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Adminn f = new Adminn();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Username or password is wrong….!!!");

        }
    }

}
