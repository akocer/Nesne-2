﻿using Microsoft.EntityFrameworkCore;

namespace uyg01.Models
{
	public class AppDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=DB01.db");
		}
	}
}
