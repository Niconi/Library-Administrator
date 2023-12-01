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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-PSDHS93\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");  
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Staff where Username = '" + comboBox1.Text + "' and Password_staff = '" + textBox2.Text + "'", koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Home panggil = new Home();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password salah! Harap mengisi username dan password dengan benar", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            forgetpass panggil = new forgetpass();
            panggil.Show();
            this.Hide();
        }
    }
}
