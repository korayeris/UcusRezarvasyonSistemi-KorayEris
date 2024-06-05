using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UçuşRezervasyonSistemi.Models;

namespace UçuşRezervasyonSistemi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Uçuş> Uçuşlar { get; set; }
        public DbSet<Lokasyon> Lokasyonlar { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\koray\Desktop\Ucusrezarvasyonsistemi.mdf;Integrated Security=True;User Instance=True");

        }
    }
}
