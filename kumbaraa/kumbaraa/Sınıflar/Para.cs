using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kumbaraa.Sınıflar
{
   public abstract class Para
    {
        public decimal Degeri { get; set; }
        public double Yukseklik { get; set; }

        public double Hacim { get; set; }
        public ParaCesitleri ParaAdı { get; set; }

        public abstract double HacimHesapla();
    }
}
