using DepartmentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartmentAPI.Data
{
	public class DepartmentDbContextClass: DbContext
	{
		private readonly IConfiguration Configuration;

		public DepartmentDbContextClass(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			//base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), options => options.EnableRetryOnFailure());
			optionsBuilder.EnableDetailedErrors();
		}

		public DbSet<Department> Departments { get; set; }
	}
}
