using Microsoft.EntityFrameworkCore;

namespace uyg02.Models
{
	public class AppDbContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=DB02.db");
		}
	}
}
