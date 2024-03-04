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
    public partial class TeknisyenKaydiSilme : Form
    {
        public TeknisyenKaydiSilme()
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

                string query = "DELETE FROM Teknisyen WHERE teknisyen_id= @teknisyen_id;";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@teknisyen_id", textBox1.Text);

                int rowsAffected = command.ExecuteNonQuery();




                connect.Close();
                MessageBox.Show("Silme işlemi gerçekleşti");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi başarısız" + ex.Message);
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

        private void TeknisyenKaydiSilme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sEZATEKNİKSERVİSİDataSet8.Teknisyen' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teknisyenTableAdapter.Fill(this.sEZATEKNİKSERVİSİDataSet8.Teknisyen);

        }
    }
}
