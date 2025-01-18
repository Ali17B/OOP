using _6_Lab.KutuphaneKonusu;

namespace _6_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kütüphane
            Yazar orhanPamuk = new Yazar { Adi = "Orhan", Soyadi = "Pamuk", Cinsiyet = true ,Id=1};
            Yazar murathanMungan = new Yazar { Adi = "Murathan", Soyadi = "Mungan", Cinsiyet = true, Id = 2 };
            Kitap yeniHayat = new Kitap
            {
                KitapAdi="Yeni Hayat",
                KitapTuru=KitapTuru.Roman,
                KitapId=1,
                Konusu="Bir gun bir kitap okudum ve butun hayatim degisti",
                Musaitmi=true,
                SayfaSayisi=250,
                Yazarlar= new List<Yazar> {orhanPamuk}
            };
            Kitap yuksekTopuklar = new Kitap
            {
                KitapAdi = "Yuksek Topuklar",
                KitapTuru = KitapTuru.Roman,
                KitapId = 1,
                Konusu = "Tugde nin gunlugu",
                Musaitmi = true,
                SayfaSayisi = 250,
                Yazarlar = new List<Yazar> { murathanMungan }
            };
            // Personel Tanimi sql insert icin - insert into Personel (Adi,Soyadi) values ('','')
            Personel ayse = new Personel { Adi = "Ayse", Id = 1, Soyadi = "Kaya" }
;
            Uye ahmet = new Uye
            {
                UyeTipi=UyeTipi.Ogrenci,
                Adi="ahmet",
                Soyadi="can",
               Id = 1
            };


            Kutuphane taksimAtaturkKutuphanesi = new Kutuphane
            {
                KutuphaneAdi = "Taksim Ataturk Kutuphanesi",
                Personeller = new List<Personel> { ayse },
                Uyeler = new List<Uye> { ahmet },
                AcilisSaati = new TimeOnly(8, 0),
                KapanisSaati = new TimeOnly(20,0)

            };

            // Kitap Hareket 
            KitapHareket kitapHareket = new KitapHareket
            {
                HareketId=1,
                HareketTipi=HareketTipi.Alis,
                KitapId=1,
                PersonelId=1,
                UyeId=1,
                SureGun=14,
                verilisTarihi=DateTime.Now
            };
            KitapHareket kitapHareket2 = new KitapHareket
            {
                HareketId = 1,
                HareketTipi = HareketTipi.Alis,
                KitapId = 2,
                PersonelId = 1,
                UyeId = 1,
                SureGun = 14,
                verilisTarihi = DateTime.Now
            };
            taksimAtaturkKutuphanesi.KitapHareketleri = new List<KitapHareket> { kitapHareket,kitapHareket2 };

            #endregion


            #region Çıkmaz Sokak
            //OkulKonusu.Adres adres = new OkulKonusu.Adres
            //{
            //    Sehir = "Van",
            //    Ilce = "Merez",
            //    CaddeSokak = "Mecburiyet Cad"
            //};

            //OkulKonusu.Kisi kisi = new OkulKonusu.Kisi
            //{
            //    Adi="ali",
            //    Adres = new OkulKonusu.Adres { Sehir="Mus",Ilce= "varto"},
            //    Soyadi= "can"

            //}; 
            #endregion

            //OkulKonusu.Kisi kisi = new OkulKonusu.Kisi
            //{
            //    Adi = "ali",
            //    Sehir = "Mus", 
            //    Ilce = "varto" ,
            //    CaddeSokak="qweasads",
            //    Soyadi = "can"
            //};




            Console.WriteLine("Hello, World!");
        }
    }
}
