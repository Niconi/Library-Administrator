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
using System.Globalization;
using System.IO;

namespace PROJECT_AKHIR
{
    public partial class peminjaman : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");

        public peminjaman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back

            Home panggil = new Home();
            panggil.Show();
            this.Hide();
        }

        private void Clear_Click(object sender, EventArgs e)
        {

            label3.Text = String.Empty;
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            textBox1.Text = String.Empty;
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Save_Buku_Click(object sender, EventArgs e)
        {
            Peminjaman buku = new Peminjaman()
            {
                No_Pinjam = Convert.ToInt32 (label3.Text),
                Id_Buku = comboBox2.Text,
                Tanggal_Pinjam = Convert.ToDateTime(dateTimePicker1.Value),
                Id_Staff = Convert.ToInt32 (comboBox1.Text),
                Id_Student = Convert.ToInt32 (textBox1.Text)
                
                
            };
            db.Peminjamans.InsertOnSubmit(buku);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Save Peminjaman Berhasil");
                Report panggil = new Report();
                panggil.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void peminjaman_Load(object sender, EventArgs e)
        {
            // nampilin data ke gridview 
            gridview_data();

            // nampilin data id buku ke combox 
            data_Buku_combo_box();

            // nampilin data id staff ke combobox
            data_idSTAFF_combo_box();
        }

        // data ke grid view
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

        // data id buku ke combo box 
        public void data_Buku_combo_box()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Id_Buku FROM DataBuku", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox2.DataSource = table1;
            comboBox2.DisplayMember = "Id_Buku";
            comboBox2.ValueMember = "Id_Buku";
        }

        // data id staff ke combo box
        public void data_idSTAFF_combo_box()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Id_Staff FROM Staff", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox1.DataSource = table1;
            comboBox1.DisplayMember = "Id_Staff";
            comboBox1.ValueMember = "Id_Staff";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //button search
            DataClasses1DataContext db = new DataClasses1DataContext();
            IQueryable<DataBuku> cust = db.DataBukus;
            if (!String.IsNullOrEmpty(textBox10.Text))
            {
                cust = cust.Where(c => c.Id_Buku == textBox10.Text);
            }
            dataGridView1.DataSource = cust;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // auto generator angka
            autogen();
        }

        public void autogen()
        {
            string num = "1234567890";
            int len = num.Length;
            string otp = string.Empty;
            int otpdigit = 5;
            string finaldigit;

            int getindex;
            for(int i=0; i < otpdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getindex].ToString();
                } while (otp.IndexOf(finaldigit) != -1);
                otp += finaldigit;
            }

            label3.Text = (otp);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
