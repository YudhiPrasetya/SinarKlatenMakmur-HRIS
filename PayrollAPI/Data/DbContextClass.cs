using Microsoft.EntityFrameworkCore;
using PayrollAPI.Model;

namespace PayrollAPI.Data {
   public class DbContextClass: DbContext {
      private readonly IConfiguration config;

      public DbContextClass(IConfiguration config) {
         this.config = config;
      }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         //base.OnConfiguring(optionsBuilder);
         optionsBuilder.UseSqlServer(this.config.GetConnectionString("DefaultConnection"));
      }

      public DbSet<Payroll> Payrolls { get; set; }
   }
}
