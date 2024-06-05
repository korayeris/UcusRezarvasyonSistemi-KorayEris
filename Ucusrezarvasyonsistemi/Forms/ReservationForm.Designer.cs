using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UçuşRezervasyonSistemi.Models;
using UçuşRezervasyonSistemi.Data;
using System.Linq;
using UcusRezarvasyonSistemi.Data;
using UcusRezarvasyonSistemi.Models;

namespace UçuşRezervasyonSistemi.Forms
{
    public partial class RezervasyonFormu : Form
    {
        // Koltuk sayısı
        private const int KoltukSayısı = 50;
        private bool[] koltukDurumu = new bool[KoltukSayısı]; // true = dolu, false = boş

        public RezervasyonFormu()
        {
            InitializeComponent();
            KoltuklarıOluştur();
            KoltukDurumlarınıGüncelle();
        }

        // Koltukları oluştur 
        private void KoltuklarıOluştur()
        {
            for (int i = 0; i < KoltukSayısı; i++)
            {
                Button koltuk = new Button();
                koltuk.Width = 50;
                koltuk.Height = 50;
                koltuk.Text = (i + 1).ToString();
                koltuk.Tag = i; // Koltuk numarasını saklamak için kullanılıyor
                koltuk.Click += Koltuk_Click;
                flowLayoutPanel1.Controls.Add(koltuk);
            }
        }

        // (boş/dolu)
        private void KoltukDurumlarınıGüncelle()
        {
            using (var db = new AppDbContext())
            {
                // Veritabanından dolu koltukların listesi
                List<int> doluKoltuklar = db.Rezervasyonlar.Select(r => r.KoltukNo).ToList();

                // Koltukları güncelle
                for (int i = 0; i < KoltukSayısı; i++)
                {
                    if (doluKoltuklar.Contains(i + 1))
                    {
                        koltukDurumu[i] = true; // Dolu
                    }
                    else
                    {
                        koltukDurumu[i] = false; // Boş
                    }
                }
            }

            // Koltukların renklerini güncelle
            for (int i = 0; i < KoltukSayısı; i++)
            {
                if (koltukDurumu[i])
                {
                    flowLayoutPanel1.Controls[i].BackColor = Color.Red; // Dolu koltuklar kırmızı
                }
                else
                {
                    flowLayoutPanel1.Controls[i].BackColor = Color.Green; // Boş koltuklar yeşil
                }
            }
        }

        
        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button tiklananKoltuk = (Button)sender;
            int koltukNo = (int)tiklananKoltuk.Tag + 1; // Koltuk numarasını al
            string mesaj = "";

            // Koltuğun durumuna göre işlem yap
            if (koltukDurumu[(int)tiklananKoltuk.Tag])
            {
                // Dolu koltuğa tıklandığında müşteri bilgilerini göster
                using (var db = new AppDbContext())
                {
                    var rezervasyon = db.Rezervasyonlar.FirstOrDefault(r => r.KoltukNo == koltukNo);
                    if (rezervasyon != null)
                    {
                        mesaj = $"Koltuk No: {rezervasyon.KoltukNo}\nMüşteri Adı: {rezervasyon.AdSoyad}\nTC No: {rezervasyon.TCNo}";
                        MessageBox.Show(mesaj, "Rezervasyon Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                // Boş koltuğa tıklandığında rezervasyon formunu aç
                RezervasyonEkleFormu rezervasyonEkleFormu = new RezervasyonEkleFormu(koltukNo);
                rezervasyonEkleFormu.ShowDialog();
            }

            // Koltuk durumlarını yeniden güncelle
            KoltukDurumlarınıGüncelle();
        }
    }
}
