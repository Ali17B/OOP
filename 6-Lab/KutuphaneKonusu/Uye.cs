using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Lab.KutuphaneKonusu
{
    public enum UyeTipi
    {
        Ogrenci=1,
        Ogretmen,
        Akademisyen,
        Arastirmaci,
        Vatandas
    }

    public class Uye:Kisi 
    {
        public UyeTipi UyeTipi { get; set; }

    }
}
