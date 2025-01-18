using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Kalitim.Araclar
{
    public class Otomobil:BaseArac
    {

        public KasaTipi KasaTipi { get; set; }
        public bool Garanti { get; set; }
        public bool AgirHasarlimi { get; set; }
    }
}
