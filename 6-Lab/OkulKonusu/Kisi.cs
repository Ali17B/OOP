using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Lab.OkulKonusu
{
    public abstract class Kisi:Adres
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
       // public Adres Adres { get; set; } => kalitim aldigi icin ve abstract oldugu icin property ozelligini kapattik
    }
}
