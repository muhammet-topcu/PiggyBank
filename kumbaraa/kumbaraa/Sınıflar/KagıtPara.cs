using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kumbaraa.Sınıflar
{
    public class KagıtPara : Para
    {

        private double _boy;
        public double Boy
        {
            get
            {
                switch (ParaAdı)
                {
                    case ParaCesitleri.OnLira:
                        _boy = 6.4;
                        break;
                    case ParaCesitleri.YirmiLira:
                        _boy = 6.8;
                        break;
                    case ParaCesitleri.ElliLira:
                        _boy = 6.8;
                        break;
                    case ParaCesitleri.YuzLira:
                        _boy = 7.2;
                        break;
                    case ParaCesitleri.İkiYuzLira:
                        _boy = 7.2;
                        break;
                }
                return _boy;
            }
        }


        private double _en;
        public double En
        {
            get
            {
                switch (ParaAdı) //Kağıt para ölçüleri "cm" cinsinden girildi.
                {

                    case ParaCesitleri.OnLira:
                        _en = (13.6)/4;
                        break;
                    case ParaCesitleri.YirmiLira:
                        _en = (14.2)/4;
                        break;
                    case ParaCesitleri.ElliLira:
                        _en = (14.8)/4;
                        break;
                    case ParaCesitleri.YuzLira:
                        _en = (15.4)/4;
                        break;
                    case ParaCesitleri.İkiYuzLira:
                        _en = 16/4;
                        break;
                        //Burada da kağıt para 4'e katlanarak kumbaraya atıldığı için eni 4 le çarptım.
                }
                return _en;
            }
        }

        public const double yukseklik = (0.25) * 4; //Kağıt Para 4'e katlandığı için.
        public const decimal OnLira = 10.00m;       //Kağıt para değeri sabit olduğu için
        public const decimal YirmiLira = 20.00m;    //"const" ile tanımladım.
        public const decimal ElliLira = 50.00m;
        public const decimal YuzLira = 100.00m;
        public const decimal İkiYuzLira = 200.00m;


        public override double HacimHesapla()
        {
            return Hacim= En * Boy * yukseklik;
            
        }
    }
}
