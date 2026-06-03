using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaYonetimSistemi
{
    public partial class SozlesmeForm1 : Form
    {
        decimal aracGunlukFiyati = 0;

        public SozlesmeForm1(string gelenPlaka, decimal gelenFiyat)
        {
            InitializeComponent();

            txtSozPlaka.Text = gelenPlaka;
            aracGunlukFiyati = gelenFiyat;
        }

        private void TutarHesapla()
        {
            TimeSpan fark = dtpTeslim.Value.Date - dtpAlis.Value.Date;
            int gunsayisi = Convert.ToInt32(fark.TotalDays);

            if (gunsayisi <= 0)
            {
                gunsayisi = 1;
            }

            decimal toplamTutar = gunsayisi * aracGunlukFiyati;
            lblSozTutar.Text = "Toplam Tutar: " + toplamTutar.ToString("C2");
        }

        private void dtpAlis_ValueChanged(object sender, EventArgs e)
        {
            TutarHesapla();
        }

        private void dtpTeslim_ValueChanged(object sender, EventArgs e)
        {
            TutarHesapla();
        }

        private void btnSozKirala_Click(object sender, EventArgs e)
        {
            if(!chkSozlesme.Checked)
            {
                MessageBox.Show("İşleme devam edebilmek için sözleşme şartlarını kabul etmelisiniz!", "Eksik Onay", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Sozlesme yeniSozlesme = new Sozlesme();
            
            yeniSozlesme.MusteriAdSoyad = txtSozAdSoyad.Text;
            yeniSozlesme.TC = txtSozTc.Text;
            yeniSozlesme.Telefon = txtSozTelefon.Text;
            yeniSozlesme.KiralananPlaka = txtSozPlaka.Text;
            yeniSozlesme.AracAlisTarihi = dtpAlis.Value;
            yeniSozlesme.AracTeslimTarihi = dtpTeslim.Value;

            MessageBox.Show("Sözleşme başarıyla oluşturuldu!\nAraç artık kirada.", "İşlem Tamam");

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}