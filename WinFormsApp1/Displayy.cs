using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.Devices;

namespace WinFormsApp1
{
    public partial class Displayy : Form
    {

        public static Displayy frm;
        public static Displayy getDisplayy
        {
            get
            {
                if (frm == null)
                {
                    frm = new Displayy();
                }
                return frm;
            }
        }

        public Displayy()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Your Movie added successfully..!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //rate movie


            RateMoive f = new RateMoive();
            f.Show();
            this.Hide();

        }

        private void Displayy_Load(object sender, EventArgs e)
        {
            textBox1.Text = allMovies.selectedrow.Cells[0].Value.ToString();
            textBox2.Text = allMovies.selectedrow.Cells[1].Value.ToString();
            textBox3.Text = allMovies.selectedrow.Cells[2].Value.ToString();
            textBox4.Text = allMovies.selectedrow.Cells[3].Value.ToString();
            textBox5.Text = allMovies.selectedrow.Cells[4].Value.ToString();
            textBox6.Text = allMovies.selectedrow.Cells[5].Value.ToString();
            textBox7.Text = allMovies.selectedrow.Cells[6].Value.ToString();


           






        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e, textBox2);
        }

        private void button4_Click(object sender, EventArgs e, System.Windows.Forms.TextBox textBox2)
        {
            //watch 
            if (textBox4.Text == "Shriek")
            {
                Shriek f = new Shriek();
                f.Show();
                this.Hide();
            }
            if (textBox4.Text == "veronic")
            {
                veronic f = new veronic();
                f.Show();
                this.Hide();
            }
            if (textBox4.Text == "ExtraAction")
            {
                ExtraAction f = new ExtraAction();
                f.Show();
                this.Hide();
            }
            if (textBox4.Text == "whitecheeks")
            {
                whitecheeks f = new whitecheeks();
                f.Show();
                this.Hide();
            }
            if (textBox4.Text == "Troll2")
            {
                Troll2 f = new Troll2();
                f.Show();
                this.Hide();
            }
            if (textBox4.Text == "RoyalTeam")
            {
                RoyalTeam f = new RoyalTeam();
                f.Show();
                this.Hide();
            }
            if (textBox4.Text == "meangirls")
            {
                meangirls f = new meangirls();
                f.Show();
                this.Hide();
            }
            
        }
    }
}
