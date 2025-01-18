using System.Reflection;

namespace _5_ObjeKavrami
{
    internal class Program
    {

        /*
         * c# da tüm veri tipleri varsayilan olarak object veri tipindedir.
         * 
         * c# compiler biz herhangi bir class olusturdugumuzda arka tarafta object turunden inherit alir.
         * Ve bir class'in ancak bir class'tan inherit(kalitim) alma zorunsalligini kirar. Bunun nedeni de 
         * bu dilde herşey ama herşey object veri tipindendir.
         * 
         * 
         */
        static void Main(string[] args)
        {

            //object myObject = new object();
           
            //Console.WriteLine(myObject.GetType());
            //Console.WriteLine(myObject.ToString());
            //Console.WriteLine(myObject.GetHashCode());
            //Console.WriteLine("**********");
            //int sayi = 5;
            //Console.WriteLine(sayi.GetType());
            //Console.WriteLine(sayi.ToString());
            //Console.WriteLine(sayi.GetHashCode());
            //Console.WriteLine("*************");
            //Temp temp = new Temp();
            
            //Console.WriteLine(temp.GetType());// Namespace ve class ismini verir.
            //Console.WriteLine(temp.ToString()); // Namespace ve class ismini verir.
            //Console.WriteLine(temp.GetHashCode()); // Hash algoritmasi sonucunu verir
            //Console.WriteLine("*************");

            #region Objelere Deger Atanmasi
            //objeler her turlu veriyi kabul eder. Boxing .
            //myObject = DateTime.Now;
            //Console.WriteLine(myObject.ToString());
            //myObject = 5;
            //Console.WriteLine(myObject.ToString());

            //myObject = "Ali Veli";
            //Console.WriteLine(myObject.ToString());
            //myObject = temp;
            //Console.WriteLine(myObject.ToString());

            #endregion
            //Console.WriteLine("UnBoxing *************");
            #region Unboxing => objeden veri cekme
            //myObject = DateTime.Now;
            ////DateTime tarih = myObject; // Bu kod hata verir. Tip Donusumu yapilmasi gerekir.
            //DateTime tarih = DateTime.Parse(myObject.ToString());
            //Console.WriteLine(tarih);

            //myObject = 5;
            //int sayi2 = int.Parse(myObject.ToString());
            //Console.WriteLine("Sayi :" + sayi2);

            //// Komplex tiplerle calisma
            //Console.WriteLine("UnBoxing Complex Type *************");
            //temp.Sayi = 34;
            //myObject = temp;
            //Temp temp1 = (Temp)myObject; //Cast islemi. Yani myOject 'e icindeki verinin Temp tipinden bir class oldugunu ifade ediyoruz.
            //Console.WriteLine(temp1.Sayi);
            #endregion

            #region Complex Type ornek 2
            //Console.WriteLine("UnBoxing Complex Type Ornek 2 *************");
            //object adres = new Adres
            //{
            //    Evmi=true,
            //    OlusturmaTarihi=DateTime.Now,
            //    PostaKodu=34330,
            //    Sehir="Van"
            //};
            //Adres adres1 = (Adres)adres;
            //Console.WriteLine(adres1.OlusturmaTarihi + " " + adres1.Evmi + " " + adres1.PostaKodu + ' ' + adres1.Sehir);

            #endregion

            #region objelerdeki hazir metodlar

            object myObject = new object();

            Console.WriteLine(myObject.GetType());
            Console.WriteLine(myObject.ToString());
            Console.WriteLine(myObject.GetHashCode());
            Console.WriteLine("**********");


                #region GetHashCode Metodu=> Elimizdeki nesnenin hash algoritmasindan gecen konudunu verir. Uniqe bir degerdir.

            Temp t1 = new Temp() { Sayi=5}; //Hafizada heap de tutulur
            Temp t2 = new Temp();//Hafizada heap de tutulur
            Console.WriteLine("T1 HashCode:"+t1.GetHashCode());
            Console.WriteLine("T2 HashCode:" + t2.GetHashCode());
            Temp t3 = t1; // Her iki nesne yani t1 ve t3 ayni yeri point ederler 
            Console.WriteLine("T3 HashCode:" + t3.GetHashCode());
            Console.WriteLine("T3 Sayi Degeri:" + t3.Sayi);
            // t3=t1 oldugunda her iki pointer ayni adres bolgesini gosterir.
            t3.Sayi = 20;
            Console.WriteLine("T1 Sayi Degeri:" + t1.Sayi); // t3'e atadigimiz deger 20 iken t1 de ayni sayi degerini gosterecektir.


            #endregion

            #region Equals metodu => iki nesnenin birbirine eşit olup olmadigini kontrol eder 

            Console.WriteLine("t1 nesnesi t2 ile ayni mi :" + t1.Equals(t2));
            Console.WriteLine("t1 nesnesi t3 ile ayni mi :" + t1.Equals(t3));

            #endregion

            #region GetType=> Reflection ile ilgili bir metoddur.

            t1.Adres = "Van";

            Console.WriteLine("Name:" + t1.GetType().Name);
            Console.WriteLine("FulllName:" + t1.GetType().FullName);
            Console.WriteLine("NameSpace:" + t1.GetType().Namespace);


            var properties = t1.GetType().GetProperties();
            Console.WriteLine("Temp Class 'i icerisindeki property'ler");
            foreach (var prop in properties)
            {
                Console.WriteLine(prop.Name);
            }

            var metodlar = t1.GetType().GetMethods();
            Console.WriteLine("Temp Class 'i icerisindeki metodlar");

            foreach (var metod in metodlar)
            {
                Console.WriteLine(metod.Name + "  Geri donus Tipi:" + metod.ReturnType.Name);
                
                if(metod.Name=="Deneme2")
                    metod.Invoke(t1,null);
                Console.WriteLine("---------------");

            }
            #endregion

            #region ToString() => metodun namespace.<object_adi> verir

            Console.WriteLine("ToString Metodu=>"+t1.ToString());
            #endregion


            #endregion
        }
    }

    public class Temp
    {
        public int Sayi { get; set; } // Property 
        public string Adres { get; set; } // Property

        public void Deneme1()  // Metod
        {
            Console.WriteLine("Temp icerisindeki deneme metodu calisti");
        }
        public string Deneme2() // Metod
        {
            return "deneme 2";
        }
    }
}
