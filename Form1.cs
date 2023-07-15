using System.Timers;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            linkLabel2.Visible = false;
        }
        int soruNo = 0, dogru = 0, yanlis = 0;
        int kalanSure = 90;

        Soru currentSoru = new Soru();
        #region

        List<Soru> soruList = new List<Soru>();

        Soru soru1 = new Soru()
        {
            SoruNo = 1,
            Id = "A",
            Cevap = "Anüs",
            SoruMetni = "Sindirimden sonra oluşan dışkıların atıldığı bölüm?"

        };
        Soru soru2 = new Soru()
        {
            SoruNo = 2,
            Id = "B",
            Cevap = "Balık",
            SoruMetni = "Protein ve D vitamini bulunan bir hayvan?"

        };
        Soru soru3 = new Soru()
        {
            SoruNo = 3,
            Id = "C",
            Cevap = "Cimri",
            SoruMetni = "Parasını harcamak istemeyen, saklayan kimse?"

        };
        Soru soru4 = new Soru()
        {
            SoruNo = 4,
            Id = "D",
            Cevap = "Daire",
            SoruMetni = "Simetri doğrusu en fazla olan geometrik şekil nedir?"

        };
        Soru soru5 = new Soru()
        {
            SoruNo = 5,
            Id = "E",
            Cevap = "Edirne",
            SoruMetni = "Bir Trakya şehri?"

        };
        Soru soru6 = new Soru()
        {
            SoruNo = 6,
            Id = "F",
            Cevap = "Fakat",
            SoruMetni = "Ama, lakin, ancak anlamında kullanılan bir kelime?"

        };
        Soru soru7 = new Soru()
        {
            SoruNo = 7,
            Id = "G",
            Cevap = "Gıda Mühendisi",
            SoruMetni = "Besinlerin işlenmesi ve paketlenmesinde Araştırma ve denetim görevi yapar?"

        };
        Soru soru8 = new Soru()
        {
            SoruNo = 8,
            Id = "H",
            Cevap = "Hakkari",
            SoruMetni = "Yüksekova ilçesinin bulunduğu şehrimiz?"

        };
        Soru soru9 = new Soru()
        {
            SoruNo = 9,
            Id = "I",
            Cevap = "Ispanak",
            SoruMetni = "Temel Reis'in yediği yemek?"

        };
        Soru soru10 = new Soru()
        {
            SoruNo = 10,
            Id = "J",
            Cevap = "Jelatin",
            SoruMetni = "Hayvan bağ dokusundan yapılan, yarı şeffaf, renksiz, kolay kırılır, tatsız katı bir maddedir."

        };
        Soru soru11 = new Soru()
        {
            SoruNo = 11,
            Id = "K",
            Cevap = "Karbonhidratlar",
            SoruMetni = "Makarna, börek, pilav gibi enerji verici yiyeceklerde bulunan genel bir besin."
        };
        Soru soru12 = new Soru()
        {
            SoruNo = 12,
            Id = "L",
            Cevap = "Lefter",
            SoruMetni = "Fenerbahçe futbol kulübünün Yunan efsane futbolcusunun adı nedir?"

        };
        Soru soru13 = new Soru()
        {
            SoruNo = 13,
            Id = "M",
            Cevap = "Mineral",
            SoruMetni = "Bütün besinlerde bulunan bir düzenleyici?"

        };
        Soru soru14 = new Soru()
        {
            SoruNo = 14,
            Id = "N",
            Cevap = "Nesnel",
            SoruMetni = "Kişinin kendi görüşlerini belirtmeyen, herkese göre aynı olan ifade."

        };
        Soru soru15 = new Soru()
        {
            SoruNo = 15,
            Id = "O",
            Cevap = "Otuz",
            SoruMetni = "ölçüleri 140˚, 70˚, 120˚ olan yamuğun diğer açısı kaç derecedir?"
        };
        Soru soru16 = new Soru()
        {
            SoruNo = 16,
            Id = "P",
            Cevap = "Pastörize",
            SoruMetni = "Süt ve konserve gibi gıdaların dayanıklı olması için yapılan bir işlem."

        };
        Soru soru17 = new Soru()
        {
            SoruNo = 17,
            Id = "R",
            Cevap = "Reklam",
            SoruMetni = "Bir ürünü tanıtmak, beğendirmek ve satmak amacıyla yapılan çalışmaların tümü"

        };
        Soru soru18 = new Soru()
        {
            SoruNo = 18,
            Id = "S",
            Cevap = "Su",
            SoruMetni = "Bütün besinlerde bulunan bir düzenleyici."

        };
        Soru soru19 = new Soru()
        {
            SoruNo = 19,
            Id = "T",
            Cevap = "Trakya",
            SoruMetni = "Yurdumuzun Avrupa topraklarında kalan bölümüne verilen ad."

        };
        Soru soru20 = new Soru()
        {
            SoruNo = 20,
            Id = "U",
            Cevap = "Usanmak",
            SoruMetni = "Bıkmak, bezmek, bir işten sıkılmak"

        };
        Soru soru21 = new Soru()
        {
            SoruNo = 21,
            Id = "V",
            Cevap = "Virüs",
            SoruMetni = "Hastalıklara yol açan mikrop veya bilgisayarları olumsuz etkileyen şey"

        };
        Soru soru22 = new Soru()
        {
            SoruNo = 22,
            Id = "Y",
            Cevap = "Yavşak",
            SoruMetni = "Bit yavrusu"

        };
        Soru soru23 = new Soru()
        {
            SoruNo = 23,
            Id = "Z",
            Cevap = "Zalim",
            SoruMetni = "haksız ve acımasız davranan, katı yürekli, kıyıcı kimse"

        };
        #endregion
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            #region sorular
            soruList.Add(soru1);
            soruList.Add(soru2);
            soruList.Add(soru3);
            soruList.Add(soru4);
            soruList.Add(soru5);
            soruList.Add(soru6);
            soruList.Add(soru7);
            soruList.Add(soru8);
            soruList.Add(soru9);
            soruList.Add(soru10);
            soruList.Add(soru11);
            soruList.Add(soru12);
            soruList.Add(soru13);
            soruList.Add(soru14);
            soruList.Add(soru15);
            soruList.Add(soru16);
            soruList.Add(soru17);
            soruList.Add(soru18);
            soruList.Add(soru19);
            soruList.Add(soru20);
            soruList.Add(soru21);
            soruList.Add(soru22);
            soruList.Add(soru23);
            #endregion
            linkLabel1.Visible = false;
            linkLabel2.Visible = true;
            linkLabel3.Visible = false;

            if (soruNo < soruList.Count)
            {
                soruNo++;
            }
            else
            {
                foreach (Control control in groupBox3.Controls)
                {
                    if (control is Button button && button.BackColor != Color.Green)
                    {
                        currentSoru = SoruGetirHarf(button.Text);
                    }
                }
            }
            currentSoru = SoruGetirSoruNo(soruNo);
            lblSoru.Text = currentSoru.Id;

            richTextBox1.Text = currentSoru.SoruMetni;


            foreach (Control control in groupBox3.Controls)
            {
                if (control is Button button && button.BackColor != Color.Green)
                {
                    soruNo = SoruGetirHarf(button.Text).SoruNo;
                }
            }
            timer1.Interval = 1000;
            timer1.Start();
            KalanSure(kalanSure);

        }

        public Soru SoruGetirSoruNo(int soruNo)
        {
            Soru soru = soruList.Where(s => s.SoruNo == soruNo).FirstOrDefault();
            return soru;
        }
        public Soru SoruGetirHarf(string harf)
        {
            Soru soru = soruList.Where(s => s.Id == harf).FirstOrDefault();
            return soru;
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2_Clicked();
        }
        private void linkLabel2_Clicked()
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Trim().ToLower() == currentSoru.Cevap.ToLower())
                {
                    foreach (Control control in groupBox3.Controls)
                    {
                        if (control is Button button && control.Text == currentSoru.Id)
                        {
                            button.BackColor = Color.Green;
                        }
                    }
                }
                else
                {
                    foreach (Control control in groupBox3.Controls)
                    {
                        if (control is Button button && control.Text == currentSoru.Id)
                        {
                            button.BackColor = Color.Yellow;
                        }
                    }
                }

                lblDogru.Text = dogru.ToString();
                lblYanlis.Text = yanlis.ToString();
                textBox1.Clear();

                if (soruNo < soruList.Count)
                {
                    soruNo++;
                    currentSoru = SoruGetirSoruNo(soruNo);

                }
                else
                {
                    foreach (Control control in groupBox3.Controls)
                    {
                        if (control is Button button && button.BackColor != Color.Green)
                        {
                            currentSoru = SoruGetirHarf(button.Text);
                        }
                    }
                }
                lblSoru.Text = currentSoru.Id;
                richTextBox1.Text = currentSoru.SoruMetni;
            }
            else
            {
                MessageBox.Show("lütfen soruyu cevaplayınız");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kalanSure--;
            if (kalanSure <= 30) { linkLabel3.Visible = true; }

            if (kalanSure <= 0)
            {
                timer1.Stop();
                Sonuc();
                MessageBox.Show($"Süre Doldu. \n Doğru sayısı : {dogru} \n Yanlış sayısı : {yanlis}");
                foreach (Control control in groupBox3.Controls)
                {
                    if (control is Button button)
                    {
                        control.BackColor = Color.Empty;
                    }
                }
                dogru = 0; yanlis = 0; soruNo = 0;
                richTextBox1.Text = "";
                linkLabel1.Visible = true;
            }

            KalanSure(kalanSure);

        }
        private void KalanSure(int kalan)
        {
            lblKalanSure.Text = kalan.ToString();
        }
        private void Sonuc()
        {
            foreach (Control control in groupBox3.Controls)
            {
                if (control is Button button && button.BackColor == Color.Green)
                {
                    dogru++;
                }
                else if (control is Button button1 && button1.BackColor == Color.Yellow)
                {
                    yanlis++;
                }
            }

        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                linkLabel2_Clicked();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
            Sonuc();
            MessageBox.Show($"Süre Doldu. \n Doğru sayısı : {dogru} \n Yanlış sayısı : {yanlis}");
            foreach (Control control in groupBox3.Controls)
            {
                if (control is Button button)
                {
                    control.BackColor = Color.Empty;
                }
            }
            dogru = 0; yanlis = 0; soruNo = 0;
            richTextBox1.Text = "";
            linkLabel1.Visible = true;
            kalanSure = 90;
            lblKalanSure.Text = "";
        }
    };

    public class Soru
    {
        public int SoruNo { get; set; }
        public string Id { get; set; }
        public string Cevap { get; set; }
        public string SoruMetni { get; set; }
    }
}