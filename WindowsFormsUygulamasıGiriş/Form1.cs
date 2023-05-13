using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUygulamasıGiriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim;
            isim = tbxName.Text;
            MessageBox.Show("Merhaba " + isim);
        }

        private void button1_Click_selamVer()
        {


        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(tbxSayi1.Text);
            sayi2 = Convert.ToInt32(tbxSayi2.Text);

            LblSonuc.Text ="Sonuc...: " + (sayi1 + sayi2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTopla.ForeColor = Color.White;
            btnTopla.BackColor = Color.Red;
        }
    }
}
