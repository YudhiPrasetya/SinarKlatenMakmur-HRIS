using Microsoft.EntityFrameworkCore;
using SuratperintahLemburAPI.Models;
//using SuratPerintahLemburAPI.Models;
using System.Collections.Generic;

namespace SuratperintahLemburAPI.Data {
   public class DbContextClass : DbContext {
      private readonly IConfiguration Configuration;

      public DbContextClass(IConfiguration configuration) {
         Configuration = configuration;
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         //base.OnConfiguring(optionsBuilder);
         optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), options => options.EnableRetryOnFailure());
      }

      public DbSet<SuratPerintahLembur> SuratPerintahLemburs { get; set; }
      //public DbSet<SPLDetail> SPLDetails { get; set; }
   }
}
