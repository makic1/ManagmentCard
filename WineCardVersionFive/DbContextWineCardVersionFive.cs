using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineCardVersionFive.Entities;

namespace WineCardVersionFive
{
    public class DbContextWineCardVersionFive : DbContext
    {
        public DbContextWineCardVersionFive()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Wine>().Property(w => w.PriceInEuro).HasPrecision(10, 2);
            modelBuilder.Entity<Account>().HasIndex(a => a.Username).IsUnique();

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    AccountId = 1,
                    Username = "admin",
                    HashPassword = BCrypt.Net.BCrypt.HashPassword("admin")
                });

            modelBuilder.Entity<WineCard>().HasData(
                new WineCard
                {
                    WineCardId = 1,
                    Name = "Unsere Weinkarte"
                });
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<GrapeVariety> GrapeVarieties { get; set; }
        public DbSet<Entities.Region> Regions { get; set; }
        public DbSet<Vintage> Vintages { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<WineCard> WineCards { get; set; }
        public DbSet<Winery> Wineries { get; set; }
        public DbSet<WineType> WineTypes { get; set; }
    }
}
