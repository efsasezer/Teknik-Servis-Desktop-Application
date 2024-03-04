using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEZA
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriKaydi musteriKaydi = new MusteriKaydi();
            musteriKaydi.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeknisyenKaydi teknisyenKaydi = new TeknisyenKaydi();
            teknisyenKaydi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CihazKaydi cihazKaydi = new CihazKaydi();
            cihazKaydi.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IslemSorgu musteriCihazBilgisi = new IslemSorgu();
            musteriCihazBilgisi.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UcretBilgisi ucretBilgisi = new UcretBilgisi();
            ucretBilgisi.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TeknisyenCihazSorgu teknisyenCihazSorgu = new TeknisyenCihazSorgu();
            teknisyenCihazSorgu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriKaydiSilme musteriKaydiSilme = new MusteriKaydiSilme();
            musteriKaydiSilme.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TeknisyenKaydiSilme teknisyenKaydiSilme = new TeknisyenKaydiSilme();
            teknisyenKaydiSilme.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
    }
}
