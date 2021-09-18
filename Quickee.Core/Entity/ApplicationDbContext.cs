using Microsoft.EntityFrameworkCore;
using Quickee.Core.Entity.EntityConfiguration;

namespace Quickee.Core.Entity
{
    public class ApplicationDbContext:DbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }

        // table
            public DbSet<ProductCategory> Categories { get; set; }
            public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // product table
            //modelBuilder.Entity<Product>()
            //    .Property(p => new { p.ProductName,
            //        p.ProductDescription,
            //        p.StockCount,
            //        p.Price,
            //        p.CategoryId
            //    })
            //    .IsRequired();

            new ProductEntityTypeConfiguration().Configure(modelBuilder.Entity<Product>());

            // define table realtionships
            modelBuilder.Entity<Product>()
               .HasOne<ProductCategory>(p => p.Category)
               .WithMany(c => c.Products)
               .HasForeignKey(p => p.CategoryId)
               .OnDelete(DeleteBehavior.SetNull);
        }
    }
}