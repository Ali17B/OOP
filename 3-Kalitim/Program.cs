using _3_Kalitim.Araclar;
using _3_Kalitim.Personeller;
using System.Security.Cryptography.X509Certificates;

namespace _3_Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ram ram = new Ram();
            // ram.Hiz = 3200;
            // ram.Marka = "Kingston";
            // ram.Model = "abc";
            // ram.Fiyat = 500;


            #region Ornek otomobil tanimlama
            Otomobil otomobil = new Otomobil();
            otomobil.Marka = "Audi";
            otomobil.Model = "A3";
            otomobil.Fiyat = 2000000;
            otomobil.Renk = System.Drawing.Color.DarkRed;
            otomobil.Km = 0;
            otomobil.VitesTipi = VitesTipi.Otomatik;
            otomobil.YakitTuru = YakitTuru.Benzin;
            otomobil.BeygirGucu = 150;
            otomobil.CekisTuru = CekisTuru.ArkaTeker;
            #endregion

            #region Enumlar ile gosterim
            //Console.WriteLine("Vites:" + (int)otomobil.VitesTipi); // Enumdaki sayisal degerini verir
            //Console.WriteLine("Cekis Turu:" + otomobil.CekisTuru); // Enumdaki name 'i verir
            //Console.WriteLine("Yakit Turu:" + Enum.GetName(typeof(YakitTuru), 2));  // Buda sayisal degeri bilinen bir enum'in name degerini getirir.
            #endregion

            #region Personel Ornegi
            Adres adres1 = new Adres
            {
                 AdresTipi=AdresTipi.EvAdresi,
                 Ulke="TR",
                 Sehir="Van",
                 Ilce="Tatvan",
                 CaddeSokak="Deneme Sokak",
                 KapiNo="5"
            };
            ITYazilimPersoneli yazilimci1 = new ITYazilimPersoneli()
            {
                Adi = "Ali",
                Soyadi = "Can",
                Departman = Departman.IT,
                Cinsiyet = true,
                //Adresler = new List<Adres>() { adres1 } // 1. Yol Listenin instance 'i alinir ve onceden olusturulmus adres degiskeni atanir.
                Adresler = new List<Adres> { new Adres { Ulke="Tr",Sehir="Mus",Ilce="Gevas"} } // Listelere eleman eklemede 2. Yol

            };
            //Listeye  veri eklemede 3. Yol 
            yazilimci1.Adresler.Add(adres1);
            //Listeye  veri eklemede 4. Yol : Adres class'indan instance alinarak yapilmasi
            yazilimci1.Adresler.Add(new Adres { Ulke="Tr",Sehir="Edirne",Ilce="Kesan"});
            #endregion


            #region Class'larin yeteneklerini (metodlarini ) kullanmak
            yazilimci1.KodYaz();
            #endregion
        }
    }
}
