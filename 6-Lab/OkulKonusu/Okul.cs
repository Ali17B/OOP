using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Lab.OkulKonusu
{
    public class Okul
    {
        public string AkulAdi { get; set; }
        public Adres Adres { get; set; }
        public List<Sinif> Siniflar { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
        public List<Ogretmen> Ogretmenler { get; set; }
        public List<DersPlan> DersPlanlari { get; set; }
        public List<Personel> Personeller { get; set; }
    }
}
