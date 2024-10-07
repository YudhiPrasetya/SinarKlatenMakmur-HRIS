using GroupAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GroupAPI.Data {
    public class GroupDbContext: DbContext {
        private readonly IConfiguration _configuration;

        public GroupDbContext(IConfiguration configuration) {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         //base.OnConfiguring(optionsBuilder);
         optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

      public DbSet<Group> Groups { get; set; }
    }
}
