using Microsoft.EntityFrameworkCore; // Bu satır eksikse hata verir

namespace MetaBiliş.Models;

public class UygulamaDbContext : DbContext // : DbContext kısmını unutma
{
    public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
    {
    }

    // "Kullanici" kelimesinin altı kırmızı çiziliyse, yukarıdaki namespace ile Kullanici.cs'deki aynı olmalı.
    public DbSet<Kullanici> Kullanicilar { get; set; }
    public DbSet<Test> Testler { get; set; }
    public DbSet<Soru> Sorular { get; set; }
    public DbSet<KullaniciCevabi> KullaniciCevaplari { get; set; }
}