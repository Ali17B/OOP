namespace _2_BilgisayarParcalari
{
    public class Bilgisayar
    {
        public AnaKart AnaKart { get; set; }
        public Kasa Kasa { get; set; }
        public Ram Ram { get; set; }
        public Islemci Islemci { get; set; }
        public HardDisk HardDisk { get; set; }
        public EkranKarti EkranKarti { get; set; }

        private decimal _fiyat;


        //Property Yontemi ile fiyat hesaplama
        public decimal Fiyat
        {
            get {
                _fiyat = AnaKart.Fiyat + Kasa.Fiyat + Ram.Fiyat + Islemci.Fiyat + HardDisk.Fiyat + EkranKarti.Fiyat;
                return _fiyat;
            }
           
        }

        //Metod Yontemi ile fiyat hesaplama
        public decimal GetFiyat()
        {
            _fiyat = AnaKart.Fiyat + Kasa.Fiyat + Ram.Fiyat + Islemci.Fiyat + HardDisk.Fiyat + EkranKarti.Fiyat;
            return _fiyat;
        }

    }
}
