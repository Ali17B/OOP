using _7_Constructor.OkulYonetim;
using _7_Constructor.Personeller;

namespace _7_Constructor
{
    internal class Program
    {
        /*
        * Custroctur => Yapici Metod Bir Siniftan instance alindiginda ilk calisan
        * 
        * Ozel bir metoddur. Bu metodun geri donus tipi yoktur.
        * 
        * Sinif ile ayni isimde olmak zorundadir.
        * 
        * Nesne ilk olusturuldugunda dişaridan parametre almak icin yada
        * Bazi Property'lere default deger vermek icin Constructer kullanilir
        * 
        * 
        * Aldigi parametreler farkli olmak kaydiyla istedigini kadar contructer yazabilirsiniz. 
        * Bu kural metod overloding kurali ile aynidir.Yani metod imzalari farkli olmak kaydiyla demektir.
        * 
        * Eger ki kalitimsal bir yapi kullanirken base class eger contructer'inda parametre bekliyor ise
        * bunu kendi constructure yapimizi kurarak ve base keywordunu kullanarak parent class'a gondermemiz zaruridir.
        * 
        * Ger ki bir den fazla paramtre alan constructer'larimiz var ise kendi icimide this keyword'u ile diger contructer'lara parametre gonderip kod tekrarindan kurtulabiliriz.
        * 
        * Bir siniftan instance alindiginda once field ve varsa propertyler set edilir
        */

        
        static void Main(string[] args)
        {
            //Personel veli = new Personel();

            // SatisPersoneli ali = new SatisPersoneli("ali", "can", "12312312311", Departman.Satis);
            // SatisPersoneli ayse = new SatisPersoneli("", "", "", Departman.IK);
            //Kisi kisi = new Kisi("ali","can","12312311211");
            //kisi.TcNo = "";

            //Console.WriteLine(kisi.TcNo);


            #region Ogrenci sinifi olusturun . bu ogrenciler ilkokul ogrencisi olsun.
            // dogum tarihini bulundugumuz yildan 7 sene oncesine otomatik olarak atayin .
            // Velevki bu okul besiktas'ta olsun. Ilceyide besiktas olarak set edin. 
            // Ayrica sinfini da 1. Sinif olarak ayarlayin. 


            //Ogrenci ali = new Ogrenci(DateTime.Now.AddYears(-7));
            //Ogrenci ali = new Ogrenci();
            // ali.DogumTarihi = DateTime.Now;
            //Console.WriteLine(ali.DogumTarihi);
            #endregion

            #region  Personel class'indan instance alininca default maas Asgari ücret olarak atansin
            /* 
             * 2- Departman a gore maas ucretlendirmesi yapilsin
             * 3- Duz personel asgari ucret alsin.
             * 4- Satis ve Finans personeli asgari ucret uzerinden yuzde 10 fazlasini alsin . Satis 
             *    personeli Ayrica satis cirosundan %2 prim verilsin 
             * 4- It persoleli Asgari ucret + yuzde 50 ile başlasin 
             * 5- Yonetim Departmani Asgari ucretin 2 kati ucret ile baslasin 
             * 
             * 
             * 
             */
            //Personel ali = new Personel("ali", "can","12312312311", Departman.DuzPersonel);
            //Console.WriteLine($"{ali.Adi} => {ali.Departman} : Maas : {ali.Maas}");
            //Personel veli = new Personel("veli", "kaya", "12312312311", Departman.Satis);
            //Console.WriteLine($"{veli.Adi} => {veli.Departman} : Maas : {veli.Maas}");

            //Personel ayse = new Personel("ayse", "demir", "12312312311", Departman.IT);

            //Console.WriteLine($"{ayse.Adi} => {ayse.Departman} : Maas : {ayse.Maas}");
            try
            {
            Personel fatma = new Personel("fatma", "Tunc", "12312312311", Departman.Yonetim);
                fatma.DogumTarihi = new DateTime(2010, 1, 1);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("test");
        
            //Console.WriteLine($"{fatma.Adi} => {fatma.Departman} : Maas : {fatma.Maas}");

            #endregion

        }
    }
}
