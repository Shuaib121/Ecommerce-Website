using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PROG7311_TASK2.Models.Admin
{
    public class ProductImage:BaseEntity
    {
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }

        public  Product Product { get; set; }
    }

    public class ProductImageMap
    {
        public ProductImageMap(EntityTypeBuilder<ProductImage> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.ImagePath);
            entityTypeBuilder.Property(x => x.Title).HasMaxLength(100);

            entityTypeBuilder.HasOne(x => x.Product).WithMany(x => x.ProductImages).HasForeignKey(x => x.ProductId);
        }
    }
}
