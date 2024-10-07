using EmployeeAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Data
{
	public class EmployeeDbContextClass: DbContext
	{
		private readonly IConfiguration Configuration;

		public EmployeeDbContextClass(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), options => options.EnableRetryOnFailure());
			optionsBuilder.EnableDetailedErrors();
			//optionsBuilder.LogTo(Console.WriteLine).EnableDetailedErrors();
		}

		public DbSet<Employee> Employees { get; set; }
	}
}
