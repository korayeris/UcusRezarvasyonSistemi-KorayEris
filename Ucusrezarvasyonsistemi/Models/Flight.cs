// Uçuş sınıfı
using System;

namespace UçuşRezervasyonSistemi.Models
{
    public class Uçuş
    {
        public int Id { get; set; }
        public string Model { get; set; } // Uçağın modeli
        public string Marka { get; set; } // Uçağın markası
        public string SeriNumarası { get; set; } // Uçağın seri numarası
        public int KoltukKapasitesi { get; set; } // Uçağın koltuk kapasitesi
    }
}
