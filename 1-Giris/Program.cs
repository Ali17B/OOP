namespace _1_Giris
{

    struct Ogrenci
    {
        public string Ad;
        public string Soyad;
        private  string TcNo;
        public void SetTcNo(string tcno)
        {
            if(tcno.Length == 11)
            {
                TcNo = tcno;
            }
            else
            {
                Console.WriteLine("Tcno  11 karakter olmalidir");
            }
        }
        public string  GetTcNo()
        {
            return string.IsNullOrEmpty(TcNo)? "" : TcNo.Substring(7, 11);
        }
    }


    public class Kisi
    {
        private string tcno;// => Field 
        public string deneme;// => Field
        public string Ad { get; set; }  // => Property
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get;  }
        public string TcNo 
        {
            get {
                return tcno.Substring(7, 11);
            };
            set
            { 
             if (value.Length == 11)
                {
                    tcno = value;
                }
                else
                {
                        tcno= "Tcno 11 karakter olmalidir";
                }
            }
        }

        public string KisiBilgileri() // =>Metod
        {
            return Ad + " " + Soyad + " " + TcNo;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Struct Ogrenci.
            // Ogrenci adında bir struct oluşturduk.
            // Structlar değer tiptir.
            // Structlar varsayılan olarak public erişim belirleyicisine sahiptir.
            // Bu yapi icerisinde TcNo alanina istiyoruz ki 11 hane disinda veri gelirse
            // TcNo alani Set edilemesin 
            // Ayrica TcNo Alani Ekrana bastirilirken 11 hane de gil son 3 hanesi gosterilsin 
            // Bu yapiyi nasil yapariz ?vBunu ancak property ile yapabiliriz 
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Ali";
            ogrenci.Soyad = "Veli";
            ogrenci.SetTcNo("12345678");

              Kisi ali = new Kisi();
                ali.Ad = "Ali";
                ali.Soyad = "Veli";
                ali.TcNo = "12345678901";
        
           
            Console.WriteLine(ogrenci.Ad);
            Console.WriteLine(ogrenci.Soyad);
            Console.WriteLine(ogrenci.GetTcNo());
        }
    }
}
