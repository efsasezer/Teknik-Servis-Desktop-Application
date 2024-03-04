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
    public partial class TeknisyenKaydi : Form
    {
        public TeknisyenKaydi()
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

                String kayit = "INSERT INTO Teknisyen (t_ad, t_soyad, t_cinsiyet, t_yas, uzmanlik, t_maas, calisma_saati) VALUES (@t_ad, @t_soyad, @t_cinsiyet, @t_yas, @uzmanlik, @t_maas, @calisma_saati)";
                SqlCommand komut = new SqlCommand(kayit, connect);



                komut.Parameters.AddWithValue("@t_ad", textBox1.Text);
                komut.Parameters.AddWithValue("@t_soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@t_cinsiyet", textBox3.Text);
                komut.Parameters.AddWithValue("@t_yas", textBox4.Text);
                komut.Parameters.AddWithValue("@uzmanlik", textBox5.Text);
                komut.Parameters.AddWithValue("@t_maas", textBox6.Text);
                komut.Parameters.AddWithValue("@calisma_saati", textBox7.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();

            this.Hide();
        }
    }
}
