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

namespace SEZA
{
    public partial class MusteriKaydi : Form
    {
        public MusteriKaydi()
        {
            InitializeComponent();
        }

        static string constring = "Data Source=localhost\\sqlexpress;Initial Catalog=SEZATEKNİKSERVİSİ;Integrated Security=True";
       
        SqlConnection connect = new SqlConnection(constring);

       
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                String kayit = "INSERT INTO Musteri (m_ad, m_soyad, adres, telefon_numarasi, email) VALUES (@m_ad, @m_soyad, @adres, @telefon_numarasi, @email)";
                SqlCommand komut = new SqlCommand(kayit, connect);



                komut.Parameters.AddWithValue("@m_ad", textBox1.Text);
                komut.Parameters.AddWithValue("@m_soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@adres", textBox3.Text);
                komut.Parameters.AddWithValue("@telefon_numarasi", textBox4.Text);
                komut.Parameters.AddWithValue("@email", textBox5.Text);
                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Kayıt eklendi");
            }

            catch (Exception)
            {
                MessageBox.Show("Kaydetme işlemi başarısız");
            }

            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }





        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();

            this.Hide();
        }
    }
}
