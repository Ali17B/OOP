namespace _4_Enum
{

    // Burada Gunler integer veri tipindendir. Default veri tipi integer'dir
    // Herhangi bir başlangiz degeri verilmez ise 0'dan başlar
    public enum Gunler
    {
        Pazar , //0
        Pazartesi,//1
        Sali, //2
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi //6
    }
    public enum Aylar : byte
    {
        Ocak = 1,
        Subat,
        Mart,
        Nisan,
        Mayis,
        Haziran, Temmuz,
        Agustos,
        Eylul,
        Ekim,
        Kasim,
        Aralik

    }

    public enum PlakaKodlari
    {
        Adana = 1,
        Ankara = 4,
        Edirne,
        Erzincan = 24,
        Erzurum,
        Istanbul = 34,
        Izmir
    }

    public enum TelefonKodlari
    {
        IstanbulAvrupa = 212,
        IstanbulAysa = 216,
        Ankara =312,
        Erzincan = 446
    }
    internal class Program
    {
        #region Tanimlama
        //Enumlar, belirli bir veri tipindeki sabit değerleri temsil etmek için kullanılır.
        //Bu sabit değerler, sembolik adlarla temsil edilir ve belirli bir sıraya sahiptirler.
        //Örneğin, bir günün haftanın hangi gününü temsil ettiğini düşünün.
        //Bu sabit değerleri enum kullanarak tanımlayabilirsiniz.
        //Default veri tipi integer'dir
        //Eger veri tipi degistirlmek istenirse : operatoru ile byte,sbyte,short v.b  tanimlamalar yapilabilir
        // Enumlar, belirli bir veri kümesini temsil etmek için kullanılırlar. 

        #endregion

        static void Main(string[] args)
        {
            #region Enum Degerlerine Erişim

            var gun = Gunler.Cuma;
            Console.WriteLine("Gun:"+gun);
            Console.WriteLine("Gun:" + (int)gun);

            #endregion

            #region Enum Degerlerini listeleme
            // Enum degereleri ile calismak icin Enum Sinifi microsoft tarafindan sunulmustur
             var gunler =  Enum.GetNames(typeof(Gunler));
            foreach (var g in gunler)
            {
                Console.WriteLine(g);
            }

            Console.WriteLine("***********************************");
            foreach (var ay in Enum.GetValues(typeof(Aylar)))
            {
                Console.WriteLine(ay);
            }
            #endregion



            var plaka = PlakaKodlari.;
            Console.WriteLine("Hello, World!");
        }
    }
}
