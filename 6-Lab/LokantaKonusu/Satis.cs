namespace _6_Lab.LokantaKonusu
{

    public enum SatisTipi
    {
        Satis=1,
        Iade=2,

    }

    public class Satis
    {
        public int Id { get; set; }
        public Personel Personel { get; set; }
        public Urun Urun { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime Tarih { get; set; }
        public SatisTipi SatisTipi { get; set; }
    }
}