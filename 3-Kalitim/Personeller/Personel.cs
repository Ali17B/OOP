using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Kalitim.Personeller
{
    public class Personel : Kisi
    {
        public Departman Departman { get; set; }
        public decimal Maas { get; set; }
    }
}
