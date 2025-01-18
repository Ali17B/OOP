using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Lab.KutuphaneKonusu
{

    public class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string Konusu { get; set; }

        public KitapTuru KitapTuru { get; set; }
        public short SayfaSayisi { get; set; }
        public bool Musaitmi { get; set; }

        public List<Yazar> Yazarlar { get; set; }
    }
}
