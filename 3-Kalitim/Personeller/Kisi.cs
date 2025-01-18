using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Kalitim.Personeller
{
    public class Kisi 
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }
        public List<Adres> Adresler { get; set; } 
    }
}
