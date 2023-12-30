using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class PDate : Form
    {
        public PDate()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");
            
           // SqlCommand cmd = new SqlCommand("SELECT * From movies where ProductionDate = 2017-11-02", con);
            string sql = "SELECT * FROM movies WHERE ProductionDate = @ProductionDate";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ProductionDate", new DateTime(2017, 11, 2));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");
            //

            //SqlCommand cmd = new SqlCommand("SELECT * From movies where ProductionDate = 2015-02-09", con);
            string sql = "SELECT * FROM movies WHERE ProductionDate = @ProductionDate";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ProductionDate", new DateTime(2015, 02, 09));
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");
            //  SqlCommand cmd = new SqlCommand("SELECT * From movies where ProductionDate = 2011-08-11", con);
            string sql = "SELECT * FROM movies WHERE ProductionDate = @ProductionDate";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ProductionDate", new DateTime(2011, 08, 11));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");
            //SqlCommand cmd = new SqlCommand("SELECT * From movies where ProductionDate = 2021-09-12", con);
            string sql = "SELECT * FROM movies WHERE ProductionDate = @ProductionDate";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ProductionDate", new DateTime(2021, 09, 12));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");
            //SqlCommand cmd = new SqlCommand("SELECT * From movies where ProductionDate = 2022-06-21", con);
            string sql = "SELECT * FROM movies WHERE ProductionDate = @ProductionDate";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ProductionDate", new DateTime(2022, 06, 21));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");

            // SqlCommand cmd = new SqlCommand("SELECT * From movies where ProductionDate = 2014-04-22", con);
            string sql = "SELECT * FROM movies WHERE ProductionDate = @ProductionDate";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ProductionDate", new DateTime(2014, 04, 22));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");

            // SqlCommand cmd = new SqlCommand("SELECT * From movies where ProductionDate = 2004-03-02 ", con);
            string sql = "SELECT * FROM movies WHERE ProductionDate = @ProductionDate";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ProductionDate", new DateTime(2004, 03, 02));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
