using GajiDanTunjanganAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GajiDanTunjanganAPI.Data {
   public class DbContextClass: DbContext {
      private readonly IConfiguration configuration;

      public DbContextClass(IConfiguration configuration) {
         this.configuration = configuration;
      }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         //base.OnConfiguring(optionsBuilder);
         optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection"));
      }

      public DbSet<GajiDanTunjangan> GajiDanTunjangans { get; set; }
   }
}
