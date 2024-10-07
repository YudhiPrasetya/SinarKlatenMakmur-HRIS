using JadwalKerjaKaryawanAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace JadwalKerjaKaryawanAPI.Data {
   public class JadwalKerjaKaryawanDbContext: DbContext {
      private readonly IConfiguration configuration;

      public JadwalKerjaKaryawanDbContext(IConfiguration configuration)
      {
         this.configuration = configuration;
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         //base.OnConfiguring(optionsBuilder);
         optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection"));
      }

      public DbSet<JadwalKerjaKaryawan> JadwalKerjaKaryawans { get; set; }
   }
}
