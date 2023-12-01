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
    public partial class bookData : Form
    {
        public bookData()
        {
            InitializeComponent();
        }

        // ini publioc void ya
        public void gridview_data()
        {
            string constring = @"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constring);

            SqlCommand cmd = new SqlCommand("SELECT * FROM DataBuku", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //INSERT

            DataClasses1DataContext db = new DataClasses1DataContext();
            DataBuku buku = new DataBuku()
            {
                Id_Buku = textBox2.Text,
                Judul_Buku = textBox1.Text,
                Kuantitas = Convert.ToInt32 (textBox6.Text),
                Kategori = textBox3.Text,
                Penerbit = textBox4.Text,
            };
            db.DataBukus.InsertOnSubmit(buku);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Insert ke Database Berhasil");
                gridview_data();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //back

            Home panggil = new Home();
            panggil.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //update

            DataClasses1DataContext db = new DataClasses1DataContext();

            var ubah = (from a in db.DataBukus
                        where a.Id_Buku == textBox2.Text
                        select a).Single();
            ubah.Judul_Buku = textBox1.Text;
            ubah.Kategori = textBox3.Text;
            ubah.Penerbit = textBox4.Text;
            ubah.Kuantitas = Convert.ToInt32(textBox6.Text);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Berhasil Update Data Buku");
                gridview_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var delete = (from a in db.DataBukus
                          where a.Id_Buku == textBox2.Text
                          select a).Single();

            db.DataBukus.DeleteOnSubmit(delete);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Berhasil Delete Data Buku");
                gridview_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button search
            DataClasses1DataContext db = new DataClasses1DataContext();
            IQueryable<DataBuku> cust = db.DataBukus;
            if (!String.IsNullOrEmpty(textBox5.Text))
            {
                cust = cust.Where(c => c.Id_Buku == textBox5.Text);
            }

            dataGridView1.DataSource = cust;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookData_Load(object sender, EventArgs e)
        {
            gridview_data();
        }
    }
    }

