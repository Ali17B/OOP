using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Constructor.OkulYonetim
{
    public class Ogrenci
    {
        // 2. Yontem Encapsulation Yontemi yani kapsulleme yontemi

        private DateTime _dogumTarihi;

        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set {
                int yas = DateTime.Now.Year - value.Year;
                _dogumTarihi = yas == 7 ? value : new DateTime(1900, 1, 1);
                //_dogumTarihi = value; 
            
            }
        }



        public string Ad { get; set; } = ""; //Default deger atamasi 
        public string Soyad { get; set; } = "";//Default deger atamasi 


        // ReadOnly Property sadece constructer icerisinden deger atanabilir
        //public DateTime DogumTarihi { get; private set; } 
        public int SinifId { get; set; }
        public string Ilce { get; set; }

        // dogum tarihini bulundugumuz yildan 7 sene oncesine otomatik olarak atayin .
        // Velevki bu okul besiktas'ta olsun. Ilceyide besiktas olarak set edin. 
        // Ayrica sinfini da 1. Sinif olarak ayarlayin. 

        // Cozum :1 Cosntructer ile deger atanmasi

        public Ogrenci()
        {
            SinifId = 1;
            Ilce = "Besiktas";

        }

        // 1. Yontem 
        //public Ogrenci(DateTime dogumTarihi):this()
        //{
        //    int yas = DateTime.Now.Year - dogumTarihi.Year;
        //    if (yas != 7)
        //        Console.WriteLine("7 yasindaki lerin disinda ogrenci kaydi yapmiyoruz");
        //    else
        //        DogumTarihi = dogumTarihi;
        //}
    }
}
