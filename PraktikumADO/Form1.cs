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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnHitungMK_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string strQuery = "SELECT COUNT(*) FROM MataKuliah";

                cmd = new SqlCommand(strQuery, conn); 

                int jumlahMK = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlahMK.ToString();

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string Query = "UPDATE Mahasiswa SET Alamat = 'Yohyakarta' WHERE NIM = '23110100001'";

                cmd = new SqlCommand(Query, conn);

                int hasil = cmd.ExecuteNonQuery();

                MessageBox.Show("jumlah baris terpengaruh :" + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnNambahData_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Dosen", conn);
                txtHasil.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSKS_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                cmd = new SqlCommand("UPDATE MataKuliah SET SKS = 4 WHERE KodeMK = 'IF210101'", conn);
                int hasil = cmd.ExecuteNonQuery();
                MessageBox.Show("SKS Berhasil Diupdate! Baris terpengaruh: " + hasil);
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnKodeMK_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "INSERT INTO ProgramStudi (KodeProdi, NamaProdi) VALUES ('MI01','Manajemen Informatika')";

                cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Prodi Berhasil Ditambahkan!");

                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show("Gagal/Sudah ada: " + ex.Message); }

        }
    }
}
