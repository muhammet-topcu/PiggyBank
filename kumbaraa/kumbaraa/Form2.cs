using kumbaraa.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kumbaraa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Kumbara kumbara = new Kumbara();
        MadeniPara madeniPara = new MadeniPara();
        KagıtPara kagıtPara = new KagıtPara();
        double KumbaradakiToplamParaHacmi;
        int kirilmaSayisi = 0;
        int calkalamaSayisi = 0;
        double paralarinHacmi = 0;
        int YapistirmaSayisi = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Para Seçimi Yapınız.";
            progressBar1.ForeColor = Color.Bisque;
            comboBox1.Items.AddRange(Enum.GetNames(typeof(ParaCesitleri)));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = comboBox1.SelectedIndex;
            switch (secim)
            {
                case 0:
                    pcb_pararesim.Image = Image.FromFile("..\\..\\ParaResimleri\\10Kuruş.png");
                    break;
                case 1:
                    pcb_pararesim.Image = Image.FromFile("..\\..\\ParaResimleri\\50Kuruş.png");
                    break;
                case 2:
                    pcb_pararesim.Image = Image.FromFile("..\\..\\ParaResimleri\\1TL.png");
                    break;
                case 3:
                    pcb_pararesim.Image = Image.FromFile("..\\..\\ParaResimleri\\10TL.png");
                    break;
                case 4:
                    pcb_pararesim.Image = Image.FromFile("..\\..\\ParaResimleri\\20TL.png");
                    break;
                case 5:
                    pcb_pararesim.Image = Image.FromFile("..\\..\\ParaResimleri\\50TL.png");
                    break;
                case 6:
                    pcb_pararesim.Image = Image.FromFile("..\\..\\ParaResimleri\\100TL.png");
                    break;
                case 7:
                    pcb_pararesim.Image = Image.FromFile("..\\..\\ParaResimleri\\200TL.png");
                    break;


            }
        }

        private void btn_paraEkle_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 38500;


            if (YapistirmaSayisi == 0)
            {

                if (KumbaradakiToplamParaHacmi < 35000)
                {

                    string secilenPara = comboBox1.Text;

                    if (secilenPara == "OnKurus" || secilenPara == "ElliKurus" || secilenPara == "BirLira")
                    {
                        madeniPara.ParaAdı = (ParaCesitleri)comboBox1.SelectedIndex;
                        kumbara.ParaEkle(madeniPara);
                        paralarinHacmi += madeniPara.Hacim;
                        KumbaradakiToplamParaHacmi += paralarinHacmi;

                        progressBar1.Value += (int)paralarinHacmi;

                    }

                    else if (secilenPara == "OnLira" || secilenPara == "YirmiLira" || secilenPara == "ElliLira" || secilenPara == "YuzLira" || secilenPara == "İkiYuzLira")
                    {
                        kagıtPara.ParaAdı = (ParaCesitleri)comboBox1.SelectedIndex;
                        kumbara.ParaEkle(kagıtPara);
                        paralarinHacmi += kagıtPara.Hacim;
                        KumbaradakiToplamParaHacmi += paralarinHacmi;

                        progressBar1.Value += (int)paralarinHacmi;
                    }

                    pcb_pararesim.Top += 180;

                    if (pcb_pararesim.Top > lbl_paragirisi.Top)
                    {

                        MessageBox.Show("Kumbaranızdaki para " + kumbara._birikenpara.ToString() + " TL'dir.");
                        pcb_pararesim.Top -= 180;
                    }
                }
                else
                {
                    MessageBox.Show(HataFırlatmaSınıfı.KumbaraDoldu());
                }
            }
            else
            {
                MessageBox.Show(HataFırlatmaSınıfı.ParaEklenmez());
            }
        }

        private void btn_KumbarayıCalkala_Click(object sender, EventArgs e)
        {
            calkalamaSayisi++;

            if (calkalamaSayisi < 2)
            {
                kumbara.Shake(KumbaradakiToplamParaHacmi);
                paralarinHacmi = KumbaradakiToplamParaHacmi - kumbara.KumbaradakiFazlaParaHacmi;
                //Kumbaradaki toplam hacimden,random ile rastgele ürettiğimiz fazla hacmin(%25-75 oranında) farkını almış olduk. 
                progressBar1.Value -= (int)(paralarinHacmi * 75) / 100;
                //Kumbarayı çalkalayarak fazladan kapladığı hacmi azaltarak yer açmış olduk.
                MessageBox.Show(HataFırlatmaSınıfı.HacimGenisletildi());
                KumbaradakiToplamParaHacmi = KumbaradakiToplamParaHacmi * 0.25;
                paralarinHacmi = paralarinHacmi * 0.25;
            }
            else
            {
                MessageBox.Show(HataFırlatmaSınıfı.CalkalamaUyarisi());
            }
        }

        private void btn_kumbarayıKır_Click(object sender, EventArgs e)
        {
            kirilmaSayisi++;

            if (kirilmaSayisi == 1)
            {
                lbl_toplam.Text = "Toplam : " + kumbara.Break().ToString() + " TL";
            }
            else
            {
                MessageBox.Show(HataFırlatmaSınıfı.KirmaUyarisi());
            }
            progressBar1.Value = 0;
        }

        private void btn_yapistir_Click(object sender, EventArgs e)
        {
            YapistirmaSayisi++;

            if (kumbara.SonDurum == KumbaraSonDurumu.Kırık)
            {
                MessageBox.Show(HataFırlatmaSınıfı.YapistirmaUyarisi());
            }
            else
            {
                MessageBox.Show("Kumbara kırık değilken yapışmaz !!!");
            }

        }
    }
}
