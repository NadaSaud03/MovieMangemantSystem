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
    public partial class Display : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-TFKVL6F;DataBase=connection; IIntegrated Security=true");

        public Display()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select* from movie", con);

            DataTable d = new DataTable();

            ad.Fill(d);

            dataGridView1.DataSource = d;

        }
    }
}
