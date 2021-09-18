using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quickee.Core.Entity.EntityConfiguration
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.ProductName)
                .IsRequired();

            builder.Property(p => p.ProductDescription)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Price)
                .IsRequired()
                .HasColumnType("decimal(5,2)");

            builder.Property(p => p.StockCount)
                .IsRequired()
                .HasDefaultValue(1);

            builder.Property(p => p.LastModified)
                .HasComputedColumnSql("GetUtcDate()");

            
        }
    }
}
