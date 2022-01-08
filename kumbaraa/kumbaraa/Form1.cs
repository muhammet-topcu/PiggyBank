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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kumbara kumbara = new Kumbara();
        MadeniPara madeniPara = new MadeniPara();
        KagıtPara kagıtPara = new KagıtPara();
        double KumbaradakiToplamParaHacmi;
        int KirilmaSayisi = 0;
        int CalkalamaSayisi = 0;
        double paralarinHacmi = 0;
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = comboBox1.SelectedIndex;
            switch (secim)
            {
                case 0:
                    pcb_para.Image = Image.FromFile("..\\..\\ParaResimleri\\10Kuruş.png");
                    break;
                case 1:
                    pcb_para.Image = Image.FromFile("..\\..\\ParaResimleri\\50Kuruş.png");
                    break;
                case 2:
                    pcb_para.Image = Image.FromFile("..\\..\\ParaResimleri\\1TL.png");
                    break;
                case 3:
                    pcb_para.Image = Image.FromFile("..\\..\\ParaResimleri\\10TL.png");
                    break;
                case 4:
                    pcb_para.Image = Image.FromFile("..\\..\\ParaResimleri\\20TL.png");
                    break;
                case 5:
                    pcb_para.Image = Image.FromFile("..\\..\\ParaResimleri\\50TL.png");
                    break;
                case 6:
                    pcb_para.Image = Image.FromFile("..\\..\\ParaResimleri\\100TL.png");
                    break;
                case 7:
                    pcb_para.Image = Image.FromFile("..\\..\\ParaResimleri\\200TL.png");
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Zaman.Start();
            comboBox1.Text = "Para Seçimi Yapınız.";
            progressBar1.ForeColor = Color.Bisque;
            comboBox1.Items.AddRange(Enum.GetNames(typeof(ParaCesitleri)));
        }

        private void btn_paraekle_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 38500;

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
                
                if (secilenPara == "OnLira" || secilenPara == "YirmiLira" || secilenPara == "ElliLira" || secilenPara == "YuzLira" || secilenPara == "İkiYuzLira")
                {
                    kagıtPara.ParaAdı = (ParaCesitleri)comboBox1.SelectedIndex;
                    kumbara.ParaEkle(kagıtPara);
                    paralarinHacmi += kagıtPara.Hacim;
                    KumbaradakiToplamParaHacmi += paralarinHacmi;

                    progressBar1.Value += (int)paralarinHacmi;
                }
                
                pcb_para.Top += 180;
                
                if (pcb_para.Top > lbl_paragırısı.Top)
                {
                     
                     MessageBox.Show("Kumbaranızdaki para " + kumbara._birikenpara.ToString() + " TL'dir.");
                     pcb_para.Top -= 180;
                }
                
            }
            else
            {
                MessageBox.Show(HataFırlatmaSınıfı.KumbaraDoldu());
            }
            
        }

        private void btn_calkala_Click(object sender, EventArgs e)
        {
            CalkalamaSayisi++;

            if (CalkalamaSayisi < 2 )
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

        private void btn_kır_Click(object sender, EventArgs e)
        {
            KirilmaSayisi++;

            if (KirilmaSayisi == 1)
            {
                lbl_toplam.Text = "Toplam : " + kumbara.Break().ToString() + " TL";
            }
            else
            {
                MessageBox.Show(HataFırlatmaSınıfı.KirmaUyarisi());
            }
            progressBar1.Value = 0;
        }

        private void btn_yapıstır_Click(object sender, EventArgs e)
        {
            if (kumbara.SonDurum == KumbaraSonDurumu.Kırık)
            {
                if (KirilmaSayisi <= 2)
                {
                    kumbara.SonDurum = KumbaraSonDurumu.Yapıştırılmış;
                    lbl_toplam.Text = "";

                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
            }
            else
            {
                MessageBox.Show("Kumbara kırık değilken yapışmaz !!!");
            }
        }
    }
}
