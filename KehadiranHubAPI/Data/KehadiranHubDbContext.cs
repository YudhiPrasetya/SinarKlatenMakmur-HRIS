using KehadiranHubAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace KehadiranHubAPI.Data {
   public class KehadiranHubDbContext: DbContext {
      private readonly IConfiguration config;

      public KehadiranHubDbContext(IConfiguration _config)
      {
         config = _config;
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
      }

      public DbSet<Kehadiran> Kehadirans { get; set; }
      //public DbSet<Employee> Employees { get; set; }
      public DbSet<JadwalKehadiran> JadwalKehadirans { get; set; }
   }
}
