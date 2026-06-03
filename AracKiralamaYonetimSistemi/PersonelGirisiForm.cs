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
    public partial class PersonelGirisiForm : Form
    {
        public PersonelGirisiForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = "admin";
            string sifre = "123";

            if(txtKullaniciAdi.Text == kullaniciAdi && txtSifre.Text == sifre)
            {
                AnaMenuForm anaMenu = new AnaMenuForm();
                anaMenu.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                txtSifre.Clear();
            }

        }
    }
}
