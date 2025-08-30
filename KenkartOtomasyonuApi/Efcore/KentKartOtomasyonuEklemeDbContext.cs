using KenkartOtomasyonuApi.Models;
using Microsoft.EntityFrameworkCore;

namespace KenkartOtomasyonuApi.Efcore
{
    public class KentKartOtomasyonuEklemeDbContext :DbContext
    {
        public DbSet<Kullanici> kullanicilar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conStr = ("Server =. ; DataBase = KentKartOtoamasyonu ; User Id =personel; Password =123456;TrustServerCertificate = true");
            optionsBuilder.UseSqlServer(conStr);
            base.OnConfiguring(optionsBuilder);
        }
    }

}
