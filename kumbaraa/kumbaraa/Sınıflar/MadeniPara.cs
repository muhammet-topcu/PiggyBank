using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kumbaraa.Sınıflar
{
    public class MadeniPara : Para
    {
        private double _yaricap;
        public double YariCap
        {
            get
            {
                switch (ParaAdı)   //Madeni para ölçüleri "cm" cinsinden girildi.
                {
                    case ParaCesitleri.OnKurus:
                        _yaricap = 1.85;
                        break;
                    case ParaCesitleri.ElliKurus:
                        _yaricap = 2.38;
                        break;
                    case ParaCesitleri.BirLira:
                        _yaricap = 2.61;
                        break;
                }
                return _yaricap;
            }
        }

        public const double PI = 3.14;   //Pı sabitini const ile tanımladım.

        private double _kalinlik;
        public double Kalinlik
        {
            get
            {
                switch (ParaAdı)
                {
                    case ParaCesitleri.OnKurus:
                        _kalinlik = 0.16;
                        break;
                    case ParaCesitleri.ElliKurus:
                        _kalinlik = 0.19;
                        break;
                    case ParaCesitleri.BirLira:
                        _kalinlik = 0.19;
                        break;

                }
                return _kalinlik;
            }
        }
        public const decimal OnKurus = 0.1m;
        public const decimal ElliKurus = 0.5m;
        public const decimal BirLira = 1.00m;

        public override double HacimHesapla()
        {
            return Hacim = PI * YariCap * YariCap * Kalinlik;

        }
    }
}
