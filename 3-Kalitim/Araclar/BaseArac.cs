using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Kalitim.Araclar
{
    public class BaseArac
    {
        public MotorTipi MotorTipi { get; set; }
        public YakitTuru YakitTuru { get; set; }
        public  CekisTuru CekisTuru { get; set; }
        public VitesTipi VitesTipi { get; set; }
        public KapiSayisi KapiSayisi { get; set; }
        public decimal Fiyat { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public Color  Renk { get; set; }
        public int UretimYili { get; set; }
        public int BeygirGucu { get; set; }
        public int MotorHacmi { get; set; }
        public int Km { get; set; }
    }
}
