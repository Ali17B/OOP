namespace _6_Lab.LokantaKonusu
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public string UrunKodu { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Adet { get; set; }
        public Birim Birim { get; set; }
    }
}