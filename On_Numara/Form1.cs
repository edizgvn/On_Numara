using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace On_Numara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sonuclar = new int[20];
        Random random = new Random();
        int[] tahminler = new int[10];

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bool durum1 = true;
            durum1 = true;

            tahminler[0] = Convert.ToInt32(txt1.Text);
            tahminler[1] = Convert.ToInt32(txt2.Text);
            tahminler[2] = Convert.ToInt32(txt3.Text);
            tahminler[3] = Convert.ToInt32(txt4.Text);
            tahminler[4] = Convert.ToInt32(txt5.Text);
            tahminler[5] = Convert.ToInt32(txt6.Text);
            tahminler[6] = Convert.ToInt32(txt7.Text);
            tahminler[7] = Convert.ToInt32(txt8.Text);
            tahminler[8] = Convert.ToInt32(txt9.Text);
            tahminler[9] = Convert.ToInt32(txt10.Text);

            for (int i = 0; i < tahminler.Length; i++)
            {
                if (Array.IndexOf(tahminler, tahminler[i]) != i)
                {
                    durum1 = false;
                    MessageBox.Show("Aynı sayi girilemez.Lütfen farklı bir sayı giriniz");
                    break;
                }
            }
            for (int i = 0; i < tahminler.Length; i++)
            {
                if (tahminler[i] < 1 || tahminler[i] > 80)
                {
                    durum1 = false;
                    MessageBox.Show("Lütfen 1 ile 80 arası bir sayı giriniz");
                    break;
                }

            }
            if (durum1 != false && durum1 != false)
            {
                for (int i = 0; i < sonuclar.Length; i++)
                {
                    int sayi = random.Next(1, 81);
                    if (Array.IndexOf(sonuclar, sayi) == -1)
                    {
                        sonuclar[i] = sayi;
                    }
                    else
                    {
                        i--;
                    }
                }
                Array.Sort(sonuclar);
                lbl1.Text = sonuclar[0].ToString();
                lbl2.Text = sonuclar[1].ToString();
                lbl3.Text = sonuclar[2].ToString();
                lbl4.Text = sonuclar[3].ToString();
                lbl5.Text = sonuclar[4].ToString();
                lbl6.Text = sonuclar[5].ToString();
                lbl7.Text = sonuclar[6].ToString();
                lbl8.Text = sonuclar[7].ToString();
                lbl8.Text = sonuclar[8].ToString();
                lbl10.Text = sonuclar[9].ToString();
                lbl11.Text = sonuclar[10].ToString();
                lbl12.Text = sonuclar[11].ToString();
                lbl13.Text = sonuclar[12].ToString();
                lbl14.Text = sonuclar[13].ToString();
                lbl15.Text = sonuclar[14].ToString();
                lbl16.Text = sonuclar[15].ToString();
                lbl17.Text = sonuclar[16].ToString();
                lbl18.Text = sonuclar[17].ToString();
                lbl19.Text = sonuclar[18].ToString();
                lbl20.Text = sonuclar[19].ToString();

                int adet = 0;
                for (int i = 0; i < tahminler.Length; i++)
                {
                    if (sonuclar.Contains(tahminler[i]))
                    {
                        adet++;
                    }
                }
                if (adet == 0 || adet >= 6)
                {
                    lblSonuc.Text = adet.ToString();
                    MessageBox.Show(adet.ToString() + "adet sayi bildiniz.Tebrikler ikramiye kazandınız");
                }
                else
                {
                    lblSonuc.Text = adet.ToString();
                    MessageBox.Show(adet.ToString() + "adet sayı tahmin ettiniz.Üzgünüz yeniden deneyiniz");
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
            txt8.Clear();
            txt9.Clear();
            txt10.Clear();
            btn2.Enabled = true;
        }
    }
}
