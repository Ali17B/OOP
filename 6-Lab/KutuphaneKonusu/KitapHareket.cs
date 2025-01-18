using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Lab.KutuphaneKonusu
{

    /*
     *  HareketTipi UyeId Personeld kitapId AlisTarihi OkumaSuresi
     *   1           1      1        1       15.01.2025   14
     * 
     * 
     * 
     */

    public enum HareketTipi:byte
    {
        Alis=1,
        Teslim,
        KayipCalinti
        
    }

    public class KitapHareket
    {
        public int HareketId { get; set; }
        public HareketTipi HareketTipi { get; set; }
        public int UyeId { get; set; }
        public int PersonelId { get; set; }
        public int KitapId { get; set; }
        public DateTime verilisTarihi { get; set; }
        public DateTime GelisTarihi { get; set; }
        public byte SureGun { get; set; }
    }
}
