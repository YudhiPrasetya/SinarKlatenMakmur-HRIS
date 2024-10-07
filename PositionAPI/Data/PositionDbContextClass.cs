using Microsoft.EntityFrameworkCore;
using PositionAPI.Models;

namespace PositionAPI.Data
{
	public class PositionDbContextClass: DbContext
	{
		private readonly IConfiguration configuration;

		public PositionDbContextClass(IConfiguration Configuration)
		{
			configuration = Configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
		}

		public DbSet<Position> Positions { get; set; }
	}
}
