using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECT_AKHIR
{
    public partial class DataBuku2 : Form
    {
        public DataBuku2()
        {
            InitializeComponent();
        }

        private void DataBuku2_Load(object sender, EventArgs e)
        {
            gridview_data();
        }

        public void gridview_data()
        {
            string constring = @"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constring);

            SqlCommand cmd = new SqlCommand("SELECT * FROM DataBuku", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //backk
            Home panggil = new Home();
            panggil.Show();
            this.Hide();
        }
    }
}
