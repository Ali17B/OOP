using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Kalitim.Araclar
{
    public enum KoltukDuzeni : byte
    {
        Klasik = 1,
        Koridorlu,
        YatarKoltuklu,
        YatarKoltukluKoridorlu
    }
    public class Otobus : BaseArac
    {
        public byte YolcuKapasitesi { get; set; }
        public KoltukDuzeni KoltukDuzeni { get; set; }
    }
}
