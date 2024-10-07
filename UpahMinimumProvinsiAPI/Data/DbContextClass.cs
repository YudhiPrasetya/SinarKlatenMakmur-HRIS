using Microsoft.EntityFrameworkCore;
using UpahMinimumProvinsiAPI.Model;
using System.Collections.Generic;

namespace UpahMinimumProvinsiAPI.Data {
   public class DbContextClass : DbContext {
      private readonly IConfiguration Configuration;

      public DbContextClass(IConfiguration configuration) {
         Configuration = configuration;
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         //base.OnConfiguring(optionsBuilder);
         optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), options => options.EnableRetryOnFailure());
      }

      public DbSet<UpahMinimumProvinsi> UMPs{ get; set; }
   }
}
