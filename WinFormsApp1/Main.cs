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
    public partial class Main : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");

        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            allMovies f = new allMovies();
            f.Show();
            this.Hide();
        }
 private void Main_Load(object sender, EventArgs e)
        {
        }
 private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
private void button1_Click(object sender, EventArgs e)
        {
        }
 private void button2_Click(object sender, EventArgs e)
        {
            allMovies f = new allMovies();
            f.Show();
            this.Hide();
        } private void button4_Click(object sender, EventArgs e)
        {
            Genre f = new Genre();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        { PDate f = new PDate();
            f.Show();
            this.Hide();
        }
    }
}

