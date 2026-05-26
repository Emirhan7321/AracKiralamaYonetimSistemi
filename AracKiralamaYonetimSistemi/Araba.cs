using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaYonetimSistemi
{
    public class Araba
    {
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal GunlukKiralamaFiyati { get; set; }  
        public string VitesTuru { get; set; }
        public bool KullanımaHazirMi { get; set; }
        public string resimYolu { get; set; }

    }
}
