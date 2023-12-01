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

    public partial class Report : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");

        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home panggil = new Home();
            panggil.Show();
            this.Hide();
        }


        public void gridview_data()
        {
            string constring = @"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constring);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Peminjaman", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void Report_Load(object sender, EventArgs e)
        {
            gridview_data();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");

            if (cmbColumn.Text == "No_Pinjam")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT No_Pinjam, Id_Buku, Tanggal_Pinjam, Id_Staff FROM Peminjaman where No_Pinjam like'" + txtSearch.Text + "%'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cmbColumn.Text == "Id_Buku")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT  Id_Buku, No_Pinjam, Tanggal_Pinjam, Id_Staff FROM Peminjaman where Id_Buku like'" + txtSearch.Text + "%'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            else if (cmbColumn.Text == "Id_Staff")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Id_Staff, No_Pinjam, Id_Buku, Tanggal_Pinjam FROM Peminjaman where Id_Staff like'" + txtSearch.Text + "%'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            else if (cmbColumn.Text == "Id_Student")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Id_Student, No_Pinjam, Id_Buku, Id_Staff, Tanggal_Pinjam FROM Peminjaman where Id_Student like'" + txtSearch.Text + "%'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }



            else if (cmbColumn.Text == "-")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Peminjaman where Tanggal_Pinjam like'" + txtSearch.Text + "%'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
    }
}
