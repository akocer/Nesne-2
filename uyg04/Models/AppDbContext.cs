using Microsoft.EntityFrameworkCore;

namespace uyg04.Models
{
	public class AppDbContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Work> Works { get; set; }
		public DbSet<Payment> Payments { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=DB04.db");
		}

	}
}
