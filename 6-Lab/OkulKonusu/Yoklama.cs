using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Lab.OkulKonusu
{
    public class Yoklama
    {
        public int Id { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public DersPlan DersPlan { get; set; }
        public DateTime Tarih { get; set; }
    }
}
