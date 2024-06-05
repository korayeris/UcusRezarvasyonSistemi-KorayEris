// Lokasyon sınıfı
namespace UçuşRezervasyonSistemi.Models
{
    public class Lokasyon
    {
        public int Id { get; set; }
        public string Ülke { get; set; } // Lokasyonun bulunduğu ülke
        public string Şehir { get; set; } // Lokasyonun bulunduğu şehir
        public string Havaalanı { get; set; } // Lokasyonun havaalanı adı
        public bool Aktif { get; set; } // Lokasyonun aktif olup olmadığı
    }
}
