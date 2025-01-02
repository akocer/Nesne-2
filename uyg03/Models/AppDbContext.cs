using Microsoft.EntityFrameworkCore;

namespace uyg03.Models
{
	public class AppDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Lesson> Lessons { get; set; }
		public DbSet<Register> Registers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=DB03.db");
		}
	}
}
