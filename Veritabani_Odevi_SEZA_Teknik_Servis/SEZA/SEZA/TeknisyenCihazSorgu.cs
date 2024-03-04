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
    public partial class TeknisyenCihazSorgu : Form
    {
        public TeknisyenCihazSorgu()
        {
            InitializeComponent();
        }

        private DataView dv;
        private void TeknisyenCihazSorgu_Load(object sender, EventArgs e)
        {

            // SqlDataAdapter nesnesi oluşturuluyor.
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Teknisyen_CihazSorgu", connect);

            // DataTable nesnesi oluşturuluyor.
            DataTable dt = new DataTable();

            // SqlDataAdapter nesnesi kullanılarak DataTable dolduruluyor.
            da.Fill(dt);

            // DataView nesnesi oluşturuluyor.
            dv = new DataView(dt);

            // DataGridView nesnesi DataSource özelliği DataView nesnesine bağlanıyor.
            dataGridView1.DataSource = dv;
        }

        static string constring = "Data Source=localhost\\sqlexpress;Initial Catalog=SEZATEKNİKSERVİSİ;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }



                connect.Close();

            }

            catch (Exception)
            {
                MessageBox.Show("Görüntüleme işlemi başarısız");
            }

            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // DataView nesnesinin RowFilter özelliği kullanılarak veriler filtreleniyor.
                dv.RowFilter = "cihaz_id = " + textBox1.Text;

                // DataGridView verilerini güncelleyin.
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtreleme işlemi başarısız: " + ex.Message);
            }
        }
    }
}
