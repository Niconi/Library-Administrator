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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void peminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ke peminjaman
            peminjaman panggil = new peminjaman();
            panggil.Show();
            this.Hide();
        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ke pengembalian
            pengembalian panggil = new pengembalian();
            panggil.Show();
            this.Hide();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // ke histor
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // kalo ini  ke report
            Report panggil = new Report();
            panggil.Show();     
            this.Hide();
        }

        private void bookDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookData panggil = new bookData();
            panggil.Show();
            this.Hide();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //logout
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm)); //you create a new thread
            this.Close(); //you close your current form (for example a menu)
            t.Start();  //you start the thread
        }
        public static void OpenLoginForm()
        {
            Application.Run(new Login()); //run your new form
        }

        private void allReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBuku2 open = new DataBuku2();
            open.Show();
            this.Hide();
        }

        private void peminjamanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Peminjaman2 open = new Peminjaman2();
            open.Show();
            this.Hide();
        }

        private void pengembalianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pengembalian2 open = new Pengembalian2();
            open.Show();
            this.Hide();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff2 open = new Staff2();
            open.Show();
            this.Hide();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student2 open = new Student2();
            open.Show();
            this.Hide();
        }

        private void laporanDataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanDataBuku panggil = new LaporanDataBuku();
            panggil.Show();
            this.Hide();
        }

        private void laporanDataStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanDataPeminjam panggil = new LaporanDataPeminjam();
            panggil.Show();
            this.Hide();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes panggil = new Notes();
            panggil.Show();
            this.Hide();
        }
    }
}
