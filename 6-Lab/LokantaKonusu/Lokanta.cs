using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _6_Lab.LokantaKonusu
{
    public class Lokanta
    {
        public int Id { get; set; }
        public string LokantaAdi { get; set; }
        public List<Urun> Urunler { get; set; }
        public List<Personel> Personeller { get; set; }
        public List<Satis> Satislar { get; set; }
    }
}
