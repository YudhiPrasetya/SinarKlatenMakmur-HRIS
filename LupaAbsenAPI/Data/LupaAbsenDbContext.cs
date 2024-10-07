using LupaAbsenAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace LupaAbsenAPI.Data {
   public class LupaAbsenDbContext: DbContext {
      private readonly IConfiguration configuration;

      public LupaAbsenDbContext(IConfiguration configuration)
      {
         this.configuration = configuration;
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         //base.OnConfiguring(optionsBuilder);
         optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection"));
      }

      public DbSet<LupaAbsen> LupaAbsens { get; set; }
   }
}
