using System;
using System.Windows.Forms;
using UçuşRezervasyonSistemi.Models;
using UçuşRezervasyonSistemi.Data;
using System.Linq;
using UcusRezarvasyonSistemi.Data;
using UcusRezarvasyonSistemi.Models;

namespace UçuşRezervasyonSistemi.Forms
{
    public partial class LokasyonFormu : Form
    {
        public LokasyonFormu()
        {
            InitializeComponent();
        }

        private void btnLokasyonlarıListele_Click(object sender, EventArgs e)
        {
            
            using (var db = new AppDbContext())
            {
                var lokasyonlar = db.Lokasyonlar.ToList();

               
                string lokasyonListesi = "";
                foreach (var lokasyon in lokasyonlar)
                {
                    lokasyonListesi += $"Ülke: {lokasyon.Ülke}, Şehir: {lokasyon.Şehir}, Havaalanı: {lokasyon.Havaalanı}, Aktif: {lokasyon.Aktif}\n";
                }

                MessageBox.Show(lokasyonListesi, "Lokasyonlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        private void LokasyonKaydet(Lokasyon yeniLokasyon)
        {
            using (var db = new AppDbContext())
            {
                db.Lokasyonlar.Add(yeniLokasyon);
                db.SaveChanges();
            }
        }
    }
}
