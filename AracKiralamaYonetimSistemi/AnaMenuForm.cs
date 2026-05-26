using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AracKiralamaYonetimSistemi
{
    public partial class AnaMenuForm : Form
    {
        public List<Araba> AracListesi = new List<Araba>();
        private string secilenResimYolu = "";
        string dosyaYolu = Application.StartupPath + "\\Araclar.txt";
        public AnaMenuForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnaMenuForm_Load(object sender, EventArgs e)
        {
            VerileriOku();
                
            foreach (Araba arac in AracListesi)
            {
                string durumYazisi = arac.KullanımaHazirMi ? "Müsait" : "Kirada";
                dgvVitrin.Rows.Add(false, null, arac.Marka, arac.Model, arac.Plaka, arac.GunlukKiralamaFiyati, arac.VitesTuru, durumYazisi);
            }
        }

        private void btnResmiSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaPencerem = new OpenFileDialog();
            dosyaPencerem.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (dosyaPencerem.ShowDialog() == DialogResult.OK)
            {
                secilenResimYolu = dosyaPencerem.FileName;
                pictBxAracResmi.ImageLocation = secilenResimYolu;
                
            }
        }

        private void btnKaydetAracBilgi_Click(object sender, EventArgs e)
        {
            Araba yeniaraba = new Araba();

            yeniaraba.Plaka = txtPlaka.Text;
            yeniaraba.Marka = txtMarka.Text;
            yeniaraba.Model = txtModel.Text;
            yeniaraba.GunlukKiralamaFiyati = Convert.ToDecimal(txtUcret.Text);
            
            if (rbtnManuel.Checked)
            {
                yeniaraba.VitesTuru = "Manuel";
            }
            else if (rbtnOtomatik.Checked)
            {
                yeniaraba.VitesTuru = "Otomatik";
            }
            
            yeniaraba.resimYolu = secilenResimYolu;
            yeniaraba.KullanımaHazirMi = true;
            AracListesi.Add(yeniaraba);
            MessageBox.Show(yeniaraba.Marka + " " + yeniaraba.Model + " Araç Sisteme Başarı ile kaydedildi!!");
            cmbAraclar.Items.Add(yeniaraba.Marka + " " + yeniaraba.Model);
            VerileriKaydet();

            txtPlaka.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtUcret.Clear();
            rbtnManuel.Checked = false;
            rbtnOtomatik.Checked = false;
            pictBxAracResmi.ImageLocation = null;

            string durumYazisi = yeniaraba.KullanımaHazirMi ? "Müsait" : "Kirada";

            dgvVitrin.Rows.Add(
                false,
                null,
                yeniaraba.Marka,
                yeniaraba.Model,
                yeniaraba.Plaka,
                yeniaraba.GunlukKiralamaFiyati,
                yeniaraba.VitesTuru,
                durumYazisi
                                );
        }

        private void cmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAraclar.SelectedIndex != -1)
            {
                Araba secilenArba = AracListesi[cmbAraclar.SelectedIndex];

                txtGuncelPlaka.Text = secilenArba.Plaka;
                txtGuncelMarka.Text = secilenArba.Marka;
                txtGuncelModel.Text = secilenArba.Model;
                txtGuncelUcret.Text = secilenArba.GunlukKiralamaFiyati.ToString();
                chkGuncelUygunluk.Checked = secilenArba.KullanımaHazirMi;
                pictBxGuncelResim.ImageLocation = secilenArba.resimYolu;

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbAraclar.SelectedIndex != -1)
            {
                AracListesi.RemoveAt(cmbAraclar.SelectedIndex);
                cmbAraclar.Items.RemoveAt(cmbAraclar.SelectedIndex);
                cmbAraclar.SelectedIndex = -1;
                MessageBox.Show("Araç Silindi!!");

                txtGuncelPlaka.Clear();
                txtGuncelMarka.Clear();
                txtGuncelModel.Clear();
                txtGuncelUcret.Clear();
                chkGuncelUygunluk.Checked = false;
                pictBxGuncelResim.ImageLocation = null;
                VerileriKaydet();
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (cmbAraclar.SelectedIndex != -1)
            {
                Araba guncellenecekAraba = AracListesi[cmbAraclar.SelectedIndex];

                guncellenecekAraba.Plaka = txtGuncelPlaka.Text;
                guncellenecekAraba.Marka = txtGuncelMarka.Text;
                guncellenecekAraba.Model = txtGuncelModel.Text;
                guncellenecekAraba.GunlukKiralamaFiyati = Convert.ToDecimal(txtGuncelUcret.Text);
                guncellenecekAraba.KullanımaHazirMi = chkGuncelUygunluk.Checked;
                guncellenecekAraba.resimYolu = pictBxGuncelResim.ImageLocation;
                MessageBox.Show("Araç Bilgileri Güncellendi");
                cmbAraclar.Items[cmbAraclar.SelectedIndex] = guncellenecekAraba.Marka + " " + guncellenecekAraba.Model;
                VerileriKaydet();
            }
        }

        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"; 

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictBxGuncelResim.ImageLocation = ofd.FileName;
            }
        }
        public void VerileriKaydet()
        {
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                foreach (Araba arac in AracListesi)
                {
                    sw.WriteLine($"{arac.Marka}|{arac.Model}|{arac.Plaka}|{arac.GunlukKiralamaFiyati}|{arac.KullanımaHazirMi}|{arac.resimYolu}|{arac.VitesTuru}");
                }
            }
        }
        public void VerileriOku()
        {
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (string satir in satirlar)
                {
                    string[] parcalar = satir.Split('|');
                    if (parcalar.Length == 7)
                    {
                        Araba arac = new Araba();
                        arac.Marka = parcalar[0];
                        arac.Model = parcalar[1];
                        arac.Plaka = parcalar[2];
                        arac.GunlukKiralamaFiyati = Convert.ToDecimal(parcalar[3]);
                        arac.KullanımaHazirMi = Convert.ToBoolean(parcalar[4]);
                        arac.resimYolu = parcalar[5];
                        arac.VitesTuru = parcalar[6];
                        
                        AracListesi.Add(arac);
                    }
                    
                }
                cmbAraclar.Items.Clear();
                foreach (Araba arac in AracListesi)
                {
                    cmbAraclar.Items.Add(arac.Marka + " " + arac.Model);
                }
            }
        }

    }
}
