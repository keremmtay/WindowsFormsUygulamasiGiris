using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUygulamasıGiriş
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();

            baglanti.ConnectionString = "Server=ASUS;Database=Northwnd13;Integrated Security=true";
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Categories", baglanti);

            DataTable dt = new DataTable();
            
            dataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            
        }
    }
}
