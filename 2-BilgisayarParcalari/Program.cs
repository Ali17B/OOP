namespace _2_BilgisayarParcalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bilgisayari olusturan parçalari modelleyin 
            // Bilgisayar => Ram, EkranKarti, Anakart, Islemci, Harddisk, Kasa
            Bilgisayar bilgisayar = new Bilgisayar();
           
            // 1. tip instance alma yontemi (instance almak demek class'in ornegini olusturmak demektir: heap 'de olusur)

            Ram ram = new Ram();
            ram.Marka = "Kingston";
            ram.Model = "abc";
            ram.Hiz = 3200;
            ram.Fiyat = 500;

            // 2. tip instance alma yontemi
            EkranKarti ekranKarti = new EkranKarti()
            {
                Marka = "Nvidia",
                Model = "abc",                
                Fiyat = 5000
            };

            // 3. tip instance alma yontemi
            AnaKart anakart = new()
            {
                Marka = "Asus",
                Model = "abc",
                Fiyat = 1000
            };

            Islemci islemci = new()
            {
                Marka = "Intel",
                Model = "abc",
                Fiyat = 2000
            };
            Kasa kasa = new()
            {
                Marka = "CoolerMaster",
                Model = "abc",
                Fiyat = 300,
                KasaTipi = KasaTipi.Tower
            };
            HardDisk hardDisk = new()
            {
                Marka = "Seagate",
                Model = "abc",
                Fiyat = 500,
                Kapasite = 1000
            };

            bilgisayar.Ram = ram;
            bilgisayar.EkranKarti = ekranKarti;
            bilgisayar.AnaKart = anakart;
            bilgisayar.Islemci = islemci;
            bilgisayar.Kasa = kasa;
            bilgisayar.HardDisk = hardDisk;

            Console.WriteLine(bilgisayar.Fiyat);

        }
    }
}
