using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Lab.KutuphaneKonusu
{
    public class Kisi
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public Adres Adres { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime? VefatTarihi { get; set; }

    }
}
