
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
namespace WinFormsApp1

{//  user Login form 
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter ad = new SqlDataAdapter("Select * from viewer where UserName='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);
            
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                SqlDataAdapter sa = new SqlDataAdapter("SELECT EndDate,UserName FROM viewer WHERE UserName = '" + textBox1.Text + "' AND EndDate>=GETDATE()", con);
                try
                {
                    if (dt.Rows.Count > 0)
                    {

                        Main f = new Main();
                        f.Show();
                        this.Hide();
                    }

                    else
                    {

                        subscription f = new subscription();
                        f.Show();
                        this.Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Something went wrong!");

                }
            }

            else
                MessageBox.Show("Username or password is wrong….!!!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
 private void label1_Click(object sender, EventArgs e)
        {

        }
 private void label2_Click(object sender, EventArgs e)
        {
        }private void textBox2_TextChanged(object sender, EventArgs e)
        {
        } private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

    }
}