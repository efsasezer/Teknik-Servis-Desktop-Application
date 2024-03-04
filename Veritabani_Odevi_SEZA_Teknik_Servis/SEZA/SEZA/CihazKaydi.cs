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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEZA
{
    public partial class CihazKaydi : Form
    {
        public CihazKaydi()
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

                String kayit = "INSERT INTO Cihaz(seri_no, cihaz_tipi ,marka ,garanti_tarihi, musteri_id ) VALUES (@seri_no, @cihaz_tipi , @marka , @garanti_tarihi, @musteri_id);";
                SqlCommand komut = new SqlCommand(kayit, connect);



                komut.Parameters.AddWithValue("@seri_no", textBox1.Text);
                komut.Parameters.AddWithValue("@cihaz_tipi", textBox2.Text);
                komut.Parameters.AddWithValue("@marka", textBox3.Text);
                komut.Parameters.AddWithValue("@garanti_tarihi", textBox4.Text);
                komut.Parameters.AddWithValue("@musteri_id", textBox5.Text);
                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Kayıt eklendi");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme işlemi başarısız" + ex.Message);
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
