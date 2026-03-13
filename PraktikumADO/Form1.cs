using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;

        private void Koneksi()
        {
            string strKoneksi = "Data Source=LAPTOP-VOL6TF2T\\RAZZAN;Initial Catalog=DBAkademikADO;Integrated Security=True";
            conn = new SqlConnection(strKoneksi);
        }   

        private void btnConnect_click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                MessageBox.Show("Koneksi ke database berhasil");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string strQuery = "SELECT COUNT(*) FROM Mahasiswa";

                cmd = new SqlCommand(strQuery, conn);

                int jumlahMhs = (int)cmd.ExecuteScalar();  

                txtHasil .Text = jumlahMhs.ToString();  

                conn.Close();
            }

        }

        private void btn(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
