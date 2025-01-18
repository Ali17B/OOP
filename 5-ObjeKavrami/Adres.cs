using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ObjeKavrami
{
    public class Adres
    {

      
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public DateTime OlusturmaTarihi{ get; set; }
        public int  PostaKodu { get; set; }
        public bool Evmi { get; set; }
    }
}
