using _6_Lab.LokantaKonusu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Lab.OkulKonusu
{
    public enum Gunler
    {
            Pazartesi=1,
            Sali,
            Carsamba,
            Persembe,
            Cuma
    }

    public class DersPlan
    {
        public int PlanId { get; set; }

        public int OgretmenId { get; set; }
        public int SinifId { get; set; }
        public Gunler   Gun { get; set; }
        public TimeOnly Saat { get; set; }
    }
}
