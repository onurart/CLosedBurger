using Microsoft.EntityFrameworkCore;

namespace ClosedBurger.Client.Models
{
    public class CloseBurgerDbContext : DbContext
    {
        public CloseBurgerDbContext()
        {

        }
        public CloseBurgerDbContext(DbContextOptions<CloseBurgerDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Branches> Branches { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("SqlServer"));
        }

    }
}
