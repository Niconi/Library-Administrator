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
    public partial class LaporanDataPeminjam : Form
    {
        public LaporanDataPeminjam()
        {
            InitializeComponent();
        }

        private void LaporanDataPeminjam_Load(object sender, EventArgs e)
        {
            NoPinjam_combo_box();
        }



        public void NoPinjam_combo_box()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Id_Buku FROM Peminjaman", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox1.DataSource = table1; 
            comboBox1.DisplayMember = "Id_Buku";
            comboBox1.ValueMember = "Id_Buku";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport4 vcr = new CrystalReport4();
            vcr.SetParameterValue("P_IdBuku", comboBox1.Text);
            crystalReportViewer1.ReportSource = vcr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home panggil = new Home();
            panggil.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
