using KehadiranAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace KehadiranAPI.Data {
   public class DbContextKehadiran: DbContext {
      private readonly IConfiguration config;

      public DbContextKehadiran(IConfiguration config)
      {
         this.config = config;
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         //base.OnConfiguring(optionsBuilder);
         optionsBuilder.UseSqlServer(this.config.GetConnectionString("DefaultConnection"));
         optionsBuilder.EnableDetailedErrors();
      }

      public DbSet<AbsenMasuk> AbsenMasuks { get; set; }
      public DbSet<AbsenPulang> AbsenPulangs { get; set; }

      public DbSet<Kehadiran> Kehadirans { get; set; }
      //public DbSet<AbsenRealTime> AbsenRealTimes { get; set; }
      public DbSet<JadwalKehadiran> JadwalKehadirans { get; set; }
   }
}
