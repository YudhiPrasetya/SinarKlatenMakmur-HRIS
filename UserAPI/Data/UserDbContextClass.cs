using Microsoft.EntityFrameworkCore;
using UserAPI.Model;

namespace UserAPI.Data
{
	public class UserDbContextClass: DbContext
	{
		private readonly IConfiguration Configuration;

		public UserDbContextClass(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
		}

		public DbSet<User> Users { get; set; }
	}
}
