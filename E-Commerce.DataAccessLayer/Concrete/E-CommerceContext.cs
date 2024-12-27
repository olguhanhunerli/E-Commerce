using E_Commerce.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccessLayer.Concrete
{
	public class E_CommerceContext: DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=OLGUHAN\\SQLEXPRESS; initial Catalog=E-CommerceDb;integrated Security=true;TrustServerCertificate=True;");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SubCategory>()
				.HasOne(sc => sc.Category)
				.WithMany(c => c.SubCategory)
				.HasForeignKey(sc => sc.CategoryID)
				.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<Product>()
				.HasOne(p => p.Category)
				.WithMany(c => c.Products)
				.HasForeignKey(p => p.CategoryID)
				.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<Product>()
				.HasOne(p => p.SubCategory)
				.WithMany(sc => sc.Product)
				.HasForeignKey(p => p.SubCategoryID)
				.OnDelete(DeleteBehavior.Restrict);
		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<SubCategory> SubCategories { get; set; }
	}
}
