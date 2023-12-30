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
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; IIntegrated Security=true");

        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter ad = new SqlDataAdapter("Select * from Admins where username='" + textBox1.Text + "' and password ='" + textBox2.Text + "'", con);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                AdminForm f = new AdminForm();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Username or password is wrong….!!!");

        }
    }
    }
