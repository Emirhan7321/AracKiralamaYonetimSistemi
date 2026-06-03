using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaYonetimSistemi
{
    internal class Sozlesme
    {
        public string MusteriAdSoyad { get; set; }
        public string TC { get; set; }
        public string Telefon { get; set; }
        public string KiralananPlaka { get; set; }
        public DateTime AracAlisTarihi { get; set; }
        public DateTime AracTeslimTarihi { get; set; }
        public decimal ToplamUcret { get; set; }
    }
}
