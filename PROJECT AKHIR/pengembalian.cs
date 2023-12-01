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
    public partial class pengembalian : Form
    {
        public pengembalian()
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

        private void pengembalian_Load(object sender, EventArgs e)
        {
            // nampilin data grid view
            gridview_data();
            // nampilin data id buku ke combox 
            data_Buku_combo_box();

            // nampilin data id staff ke combobox
            data_idSTAFF_combo_box();

            databuku();
            datastaff();
            idstudent();
        }


        public void databuku()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Id_Buku FROM Pengembalian", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox1.DataSource = table1;
            comboBox1.DisplayMember = "Id_Buku";
            comboBox1.ValueMember = "Id_Buku";
        }

        public void datastaff()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Id_Staff FROM Staff", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox2.DataSource = table1;
            comboBox2.DisplayMember = "Id_Staff";
            comboBox2.ValueMember = "Id_Staff";
        }

        public void idstudent()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Id_Student FROM Peminjaman", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox3.DataSource = table1;
            comboBox3.DisplayMember = "Id_Student";
            comboBox3.ValueMember = "Id_Student";
        }



        // nampilin data grid view
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

        public void data_Buku_combo_box()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Id_Buku FROM DataBuku", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

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
        }


        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Save_Buku_Click(object sender, EventArgs e)
        {
            Pengembalian buku = new Pengembalian()
            {
                No_Kembali = Convert.ToInt32(label2.Text),
                Id_Buku = comboBox1.Text,
                Id_Staff = Convert.ToInt32 (comboBox2.Text),
                Tanggal_Kembali = Convert.ToDateTime(dateTimePicker1.Value),
                Jumlah_Denda = Convert.ToInt32 (textBox2.Text),
                Id_Student = Convert.ToInt32 (comboBox3.Text)
            };
            db.Pengembalians.InsertOnSubmit(buku);
            try
            {   
                db.SubmitChanges();
                MessageBox.Show("Save Pengembalian Berhasil");
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //search
        private void button2_Click(object sender, EventArgs e)
        {
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
            for (int i = 0; i < otpdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getindex].ToString();
                } while (otp.IndexOf(finaldigit) != -1);
                otp += finaldigit;
            }

            label2.Text = (otp);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            label2.Text = string.Empty;
        }
    }
}
