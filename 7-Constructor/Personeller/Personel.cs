using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Constructor.Personeller
{
    public class Personel:Kisi
    {
        private decimal _prim=0;

        public decimal Prim
        {
            get
            {
                var departman = Enum.GetNames(typeof(Departman));
                if (departman.Contains("Finans") || departman.Contains("Yonetim"))
                {
                    return _prim;

                }
                else
                {
                    Console.WriteLine("Primleri gorme yetkiniz yok");
                    return 0;
                }

            }
            set { 
                if(value>0)
                   _prim = value; 
            }
        }

        private decimal _maas = 22104.00m;
        public decimal Maas {
            get
            {
                return _maas;

            }
            private set
            {
                _maas = value;
            }
          }
        public Departman Departman { get; set; }






        // Boş constructer
        public Personel()
        {
        }

        /*
         * 1- Tcno 11 karaktermi Dikkat edilsin. Disariya son 4 hanesi verilsin
         * 2- Ad , soyad alani en az 2 karakter olsun 
         * 3- Maas alani Eger Duz personel ise Asgari ucret olarak otomatik olarak atansin 
         * 
         * 
         * 
         * Odev Kurallar : 
         * Email Check edilecek
         * Dogum Tarihine bakilacak
         * Ad soyad en az 2 karakter olacak
         * 
         * Gsm numarasi :532 111 22 33 => en az 10 olacak.
         */
        public Personel(string adi,string soyadi,string tcno,Departman departman)
        {

            Adi = adi;
            Soyadi = soyadi;
            TcNo = tcno;
            Departman = departman;
            switch (departman)
            {
                case Departman.DuzPersonel:
                    break;
                case Departman.Satis:
                    _maas += _maas * 0.1m;
                    break;
                case Departman.Finans:
                    _maas += _maas * 0.1m;

                    break;
                case Departman.IT:
                    _maas += _maas * 0.5m;

                    break;
                case Departman.Yonetim:
                    _maas += _maas ;

                    break;
                case Departman.IK:
                    break;
                case Departman.Hukuk:
                    break;
                case Departman.Proje:
                    break;
                default:
                    break;
            }
            //Departman = departman;
        }
        public Personel(string adi, string soyadi, string tcno,DateTime dogumTarihi, Departman departman):this(adi,soyadi,tcno,departman)
        {

            DogumTarihi = dogumTarihi;
        }
    }
}
