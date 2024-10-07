using Microsoft.EntityFrameworkCore;

namespace ExceptionAPI.Data {
   public class ExceptionDBContext: DbContext {
      private readonly IConfiguration configuration;

      public ExceptionDBContext(IConfiguration Configuration) {
         configuration = Configuration;
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         //base.OnConfiguring(optionsBuilder);
         optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
      }

      public DbSet<Model.Exception> Exceptions { get; set; }
   }
}
