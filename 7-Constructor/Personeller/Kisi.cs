using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Constructor.Personeller
{
    public  class Kisi
    {
        #region Field'lar

        private string _tcno = "";// field 
        private string _email = "";
        protected string _ad = "";
        private string _soyad = "";
        private string _gsm = "";
        private DateTime _dogumTarihi;
        #endregion
        #region Property'ler
        public string Adi
        {
            get
            {
                return _ad;
            }


            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 1)
                {
                    _ad = value;
                }

            }
        }
        public string Soyadi
        {
            get
            {
                return _soyad;
            }


            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 1)
                {
                    _soyad = value;
                }

            }
        }
        public string Gsm
        {
            get
            {
                return _gsm;
            }


            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 9)
                {
                    _gsm = value;
                }

            }
        }

        //Email Check yapilmasi lazim
        // @ isareti varmi ? . .com,.net, .org,.gov,.edu , .edu.tr 
        public string Email
        {
            get { return _email; }
            set
            {
                if (!string.IsNullOrEmpty(value)
                  && value.Contains('@')
                  && (value.Contains(".com") ||
                       value.Contains(".net") ||
                       value.Contains(".gov")))
                {
                    _email = value;
                }

            }
        }

        //18 yaş alti cocuk çaliştirilamaz . Devlet'in koydugu kural.
        public DateTime DogumTarihi
        {
            get
            {
                return _dogumTarihi;
            }
            set
            {
                if ((DateTime.Now.Year - value.Year) > 17)
                    _dogumTarihi = value;
                else
                {
                    throw new Exception("18 yasindan kucuklari calistirmiyoruz");
                }
            }
        }
        public bool Cinsiyet { get; set; }
        public string TcNo
        {
            get
            {

                return _tcno.Length == 11 ? "*******" + _tcno.Substring(7) : "Tcno Atanmamis";
            }
            set
            {
                if (value.Length != 11)
                {
                    Console.WriteLine("Tc no 11 karakter olmalidir");
                }
                else
                {
                    _tcno = value;
                }
            }

        }
        public List<Adres> Adresler { get; set; } 
        #endregion
        public Kisi()
        {
            Adresler = new List<Adres>();
            Adres adres = new Adres
            {
                Ulke = "TR"
            };
            Adresler.Add(adres);
        }

        public Kisi(string adi):this()
        {
            Adi = adi;
        }

        public Kisi(string adi ,string soyadi):this(adi)
        {
            
            Soyadi = soyadi;
        }
        public Kisi(string adi, string soyadi,string tcno):this(adi,soyadi)
        {
           
            TcNo = tcno;
        }
    }
}
