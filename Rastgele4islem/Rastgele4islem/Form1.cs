using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rastgele4islem
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int sayi1, sayi2,seviye=1,isaret,counter=5;
        double kuvvet, sonuc;
        Random rnd = new Random();

        private void btnCevapla_Click(object sender, EventArgs e)
        {
            try { 
                if (sonuc == Convert.ToDouble(txtInput.Text))
                {
                    seviye++;
                    counter = 5;
                    OyunYinele();
                }
                else
                {
                    OyunBitti();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen bir rakam giriniz.");
            }
        }

        private void OyunBitti()
        {
            timer1.Stop();
            btnCevapla.Visible = false;
            btnYeniOyun.Visible = true;
            MessageBox.Show("Oyun bitti");
            txtInput.Text = "";
            txtInput.Visible = false;
            lblIsaret.Visible = false;
            lblSayi1.Visible = false;
            lblSayi2.Visible = false;
            lblSure.Visible = false;
        }

        private void OyunYinele()
        {
            SayilariOlustur();
            IsaretOlustur();
            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                OyunBitti();
            }

        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnCevapla.PerformClick();
            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            OyunYinele();
            counter = 5;
            btnCevapla.Visible = true;
            btnYeniOyun.Visible = false;
            txtInput.Visible = true;
            lblIsaret.Visible = true;
            lblSayi1.Visible = true;
            lblSayi2.Visible = true;
            lblSure.Visible = true;
            timer1.Start();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void SayilariOlustur()
        {
            kuvvet = Math.Pow(Convert.ToDouble(10), Convert.ToDouble(seviye));
            sayi1 = Convert.ToInt32(rnd.Next(1, Convert.ToInt32(kuvvet)));
            sayi2 = Convert.ToInt32(rnd.Next(1, Convert.ToInt32(kuvvet)));
            lblSayi1.Text = sayi1.ToString();
            lblSayi2.Text = sayi2.ToString();
        }

        private void IsaretOlustur()
        {
            isaret = rnd.Next(1, 5);
            switch (isaret){
                case 1:
                    lblIsaret.Text = "+";
                    sonuc = sayi1 + sayi2;
                    break;
                case 2:
                    lblIsaret.Text = "-";
                    sonuc = sayi1 - sayi2;
                    break;
                case 3:
                    lblIsaret.Text = "x";
                    sonuc = sayi1 * sayi2;
                    break;
                case 4:
                    lblIsaret.Text = "/";
                    sonuc = Convert.ToDouble(sayi1) / Convert.ToDouble(sayi2);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SayilariOlustur();
            IsaretOlustur();
            timer1.Interval=1000;
            timer1.Start();
        }
    }
}
