using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kumbaraa.Sınıflar
{
    public class Kumbara : ICalkalamaMetodu
    {
        Random rnd = new Random();

        public double KumbaradakiFazlaParaHacmi { get; set; }
        public double Hacim
        {
            get
            {
                return 35500;
            }
            set
            {

            }
        }
        public decimal _birikenpara = 0;
        private KumbaraSonDurumu _sondurum = KumbaraSonDurumu.Yeni;
        public KumbaraSonDurumu SonDurum
        {
            get
            {
                return _sondurum;
            }
            set
            {
                _sondurum = value;
                if (_sondurum == KumbaraSonDurumu.Yapıştırılmış)
                {
                    System.Windows.Forms.MessageBox.Show(HataFırlatmaSınıfı.KumbaraYapistirildi());

                }
            }
        }

        public double Shake(double FazladanKaplananHacim)
        {
            return FazladanKaplananHacim * 0.25;
        }

        public void ParaEkle(Para para)
        {
           
            switch (para.ParaAdı)
            {
                case ParaCesitleri.OnKurus:
                    para.Degeri = MadeniPara.OnKurus;
                    break;
                case ParaCesitleri.ElliKurus:
                    para.Degeri = MadeniPara.ElliKurus;
                    break;
                case ParaCesitleri.BirLira:
                    para.Degeri = MadeniPara.BirLira;
                    break;
                case ParaCesitleri.OnLira:
                    para.Degeri = KagıtPara.OnLira;
                    break;
                case ParaCesitleri.YirmiLira:
                    para.Degeri = KagıtPara.YirmiLira;
                    break;
                case ParaCesitleri.ElliLira:
                    para.Degeri = KagıtPara.ElliLira;
                    break;
                case ParaCesitleri.YuzLira:
                    para.Degeri = KagıtPara.YuzLira;
                    break;
                case ParaCesitleri.İkiYuzLira:
                    para.Degeri = KagıtPara.İkiYuzLira;
                    break;
                

            }

            _birikenpara += para.Degeri;   //Kumbaraya eklenen paralar toplanıyor.
            

            KumbaradakiFazlaParaHacmi = para.HacimHesapla() * rnd.Next(25, 75) / 100;
            //Burası da; kumbaraya rastgele atılan paraların, kumbara içerisinde dağınık kaldığı için fazladan kapladığı hacmi temsil ediyor.%25-75 oranında fazladan yer kaplamış oldu.
        }
        public decimal Break()
        {

            decimal tumPara = _birikenpara;
            _birikenpara = 0;
            SonDurum = KumbaraSonDurumu.Kırık;
            System.Windows.Forms.MessageBox.Show(HataFırlatmaSınıfı.KumbaraKirildi());
            return tumPara;
        }
        
           
    }
}
