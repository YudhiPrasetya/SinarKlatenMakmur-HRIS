using MesinAbsenAPI.Model;
using MesinAbsenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MesinAbsenAPI.Data
{
  public class MesinAbsenDbContextClass: DbContext
  {
      private readonly IConfiguration Configuration;

      public MesinAbsenDbContextClass(IConfiguration configuration)
      {
      Configuration = configuration;
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
      //base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
      }

      public DbSet<MesinAbsen> MesinAbsens { get; set; }
      public DbSet<LogMesinAbsen> LogMesinAbsen { get; set; }
      public DbSet<AbsenRealTime> AbsenRealTimes { get; set;}
  }
}
