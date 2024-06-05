// Rezervasyon sınıfı
using System;

namespace UçuşRezervasyonSistemi.Models
{
    public class Rezervasyon
    {
        public int Id { get; set; }
        public int UçuşId { get; set; } // Rezervasyonun hangi uçuşa ait olduğu
        public int KoltukNo { get; set; } // Rezervasyonun yapıldığı koltuk numarası
        public string AdSoyad { get; set; } // Rezervasyon yapan kişinin adı soyadı
        public string TCNo { get; set; } // Rezervasyon yapan kişinin TC numarası
        public DateTime RezervasyonTarihi { get; set; } // Rezervasyonun yapıldığı tarih
        public bool Satıldı { get; set; } // Koltuğun satıldı mı yoksa boş mu olduğu
    }
}
