using Microsoft.EntityFrameworkCore;
using ShiftAPI.Models;

namespace ShiftAPI.Data {
	public class ShiftDbContext: DbContext {
		private readonly IConfiguration config;

		public ShiftDbContext(IConfiguration config)
      {
			this.config = config;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			//base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(this.config.GetConnectionString("DefaultConnection"));
		}

		public DbSet<JadwalShiftKaryawan> JadwalShiftKaryawans { get; set; }
		public DbSet<JadwalShiftSecurity> JadwalShiftSecurities { get; set; }
		public DbSet<JamKerja> JamKerjas { get; set; }

		public DbSet<JadwalShiftDepartemen> JadwalShiftDepartemens { get; set; }
	}


}
