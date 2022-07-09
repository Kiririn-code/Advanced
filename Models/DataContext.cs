using Microsoft.EntityFrameworkCore;

namespace Advanced.Models
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Person> People { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Departament> Departaments { get; set; }
    }
}