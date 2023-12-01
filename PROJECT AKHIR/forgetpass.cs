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
    public partial class forgetpass : Form
    {
        public forgetpass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login panggil = new Login();
            this.Hide();
            panggil.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var ubah = (from a in db.Staffs
                        where a.Username == comboBox1.Text
                        select a).Single();

            ubah.Password_staff = textBox2.Text;


            try
            {
                db.SubmitChanges();
                MessageBox.Show("Berhasil Update Password Staff");
                Login panggil = new Login();
                this.Hide();
                panggil.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
   }

