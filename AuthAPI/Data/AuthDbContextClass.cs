using AuthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthAPI.Data {
	public class AuthDbContextClass: DbContext {
		private readonly IConfiguration _configuration;

		public AuthDbContextClass(IConfiguration configuration) {
			_configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			//base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
		}

		public DbSet<User> Users { get; set; }
	}
}
