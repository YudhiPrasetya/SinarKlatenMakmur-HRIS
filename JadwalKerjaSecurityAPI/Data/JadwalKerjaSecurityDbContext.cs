using JadwalKerjaSecurityAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace JadwalKerjaSecurityAPI.Data {
	public class JadwalKerjaSecurityDbContext: DbContext {
		private readonly IConfiguration configuration;

		public JadwalKerjaSecurityDbContext(IConfiguration configuration) {
			this.configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			//base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection"));
		}

		public DbSet<JadwalKerjaSecurity> JadwalKerjaSecurities { get; set; }
	}
}
