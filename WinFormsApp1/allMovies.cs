using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsApp1
{
    public partial class allMovies : Form
    { public allMovies()
        {

            InitializeComponent();
        }

        private void allMovies_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("SELECT id,name,genre,age,shortDescription,rating,ProductionDate From movies ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public static DataGridViewRow selectedrow;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = dataGridView1.Rows[e.RowIndex];
                Displayy.getDisplayy.ShowDialog();
            }
        }private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

