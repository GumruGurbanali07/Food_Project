using Food_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Food_Project.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 

		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Food> Foods { get; set; }
		public DbSet<Admin> Admins { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>()
			  .HasKey(x => x.CategoryId);
			modelBuilder.Entity<Food>()
				.HasOne(y => y.Category)
				.WithMany(x => x.Foods)
				.HasForeignKey(y => y.CategoryId);
		}
	}
}
