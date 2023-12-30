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
    public partial class Adminn : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");
        public Adminn()
        {
            InitializeComponent();
        }
        private void Adminn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            KeepTrack f = new KeepTrack();
            f.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Addmoviee f = new Addmoviee();
            f.Show();
            this.Hide();
        }
    }
}
