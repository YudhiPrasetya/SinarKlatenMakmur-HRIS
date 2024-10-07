using Microsoft.EntityFrameworkCore;
using PenghasilanTidakKenaPajakAPI.Model;

namespace PenghasilanTidakKenaPajakAPI.Data
{
	public class DbContextClass: DbContext
	{
		private readonly IConfiguration configuration;

		public DbContextClass(IConfiguration Configuration)
		{
			configuration = Configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
		}

		public DbSet<PenghasilanTidakKenaPajak> PTKPs { get; set; }
	}
}
