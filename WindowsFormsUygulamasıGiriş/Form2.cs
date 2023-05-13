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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbSehirler.Items.Add("İstanbul");
            cmbSehirler.Items.Add("İzmir");
            cmbSehirler.Items.Add("Ankara");
            cmbSehirler.Items.Add("Bursa");
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbSehirler.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "";
            if (cboxSehir.Checked)
            {
                data += cboxSehir.Text + " ";
            }
            if (cboxSehir1.Checked)
            {
                data += cboxSehir1.Text + " ";
            }
            if (cboxSehir3.Checked)
            {
                data += cboxSehir3.Text + " ";
            }
            label2.Text = data;

            MessageBox.Show(data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string cinsiyet = "";

            if (radiobtnKadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            else if (radiobtnErkek.Checked)
            {
                cinsiyet = "Erkek";
            }

            MessageBox.Show(cinsiyet);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string bolge = "";
            //bolge = radioButton1.Checked.ToString();


            if (radioButton1.Checked)
            {
                bolge = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                bolge = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                bolge = radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                bolge = radioButton4.Text;
            }
            if (radioButton5.Checked)
            {
                bolge = radioButton5.Text;
            }
            if (radioButton6.Checked)
            {
                bolge = radioButton6.Text;
            }
            if (radioButton7.Checked)
            {
                bolge = radioButton7.Text;
            }

            MessageBox.Show(bolge);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;

            MessageBox.Show("Tarih... : " + date.ToString());
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Blue;
        }
    }
}
