using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Kalitim
{
    public class AnaKart : BaseItem
    {
        public string SoketTipi { get; set; }
        public string Chipset { get; set; }
        public int RamSlotSayisi { get; set; }
        public int UsbPortSayisi { get; set; }
        public int SataPortSayisi { get; set; }
    }
}
