using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace PROJECT_AKHIR
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e)
        {

        }
        static string Baca()

        {
            FileStream fs = new FileStream("D:\\testtxt\\notes.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            return (sr.ReadToEnd());
            sr.Close();
            fs.Close();
           
        }

        static void Tulis(string kata)

        {
            FileStream fs = new FileStream("D:\\testtxt\\notes.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(kata);
            sw.Close();
            fs.Close(); 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tulis(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Baca();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home panggil = new Home();
            panggil.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
