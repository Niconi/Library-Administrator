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
    public partial class Pengembalian2 : Form
    {
        public Pengembalian2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //backk
            Home panggil = new Home();
            panggil.Show();
            this.Hide();
        }

        private void Pengembalian2_Load(object sender, EventArgs e)
        {
            gridview_data();
        }


        public void gridview_data()
        {
            string constring = @"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constring);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Pengembalian", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }

}
