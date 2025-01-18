using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _7_Constructor.Personeller
{
    public class SatisPersoneli:Personel
    {
        public SatisPersoneli(string adi,string soyadi,string tcno,Departman departman):base(adi,soyadi,tcno,departman)
        {
            
        }
    }
}
