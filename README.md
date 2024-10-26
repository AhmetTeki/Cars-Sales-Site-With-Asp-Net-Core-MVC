Projenin doğru çalışması için OtoServisSatis.Data klasörünün altına "DataBaseContext.cs" adında bir sınıf ekleyin.




using Microsoft.EntityFrameworkCore;
**********************************************************************************************************************************************
using OtoServisSatis.Entity;
**********************************************************************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OtoServisSatis.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Servis> Servisler { get; set; }
        public DbSet<Slider> Sliders{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@" *************************************************************************************");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                Id= 1,
                Adi="Admin"
            });
            modelBuilder.Entity<Kullanici>().HasData(new Kullanici
            {
                Id= 21,
                Adi = "Admin",
                Soyadi="admin",
                Telefon="0850",
                AktifMi = true,
                EklenmeTarihi = DateTime.Now,
                Email = "admin@otoservissatis.tc",
                KullaniciAdi = "admin",
                Sifre = "123456",
               /// Rol=new Rol { Id=1,},
                RolId = 1,
                
            });
            base.OnModelCreating(modelBuilder);
        }
    }
} 






ardından içine yukardaki kodu ekleyin
ardından yukarıdaki koddaki ***************** ile işaretlediğim yere kendi veri tabanı yolunuzu ekleyin
ardından OtoServisSatis.Data klasöründe terminal açıp sırasıyla "dotnet ef migrations add AddedNewColumn" ve "dotnet ef database update" kommutlarını çalıştırın
ardından uygulamayı kullanabilirsiniz kayıt olup admin panelinide görüntüleyebilirsiniz
