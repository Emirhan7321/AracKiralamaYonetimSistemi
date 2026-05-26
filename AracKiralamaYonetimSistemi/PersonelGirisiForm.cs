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
            
            AnaMenuForm anaMenu = new AnaMenuForm();
            anaMenu.Show();

        }
    }
}
