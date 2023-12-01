using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_AKHIR
{
    public partial class LaporanDataBuku : Form
    {
        public LaporanDataBuku()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport3 VCR = new CrystalReport3();
            crystalReportViewer1.ReportSource = VCR;
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
    }
}
