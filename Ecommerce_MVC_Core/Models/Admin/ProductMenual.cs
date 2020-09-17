using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PROG7311_TASK2.Models.Admin
{
    public class ProductManual:BaseEntity
    {
        public int ProductId { get; set; }
        public string ManualName { get; set; }

        public Product Product { get; set; }

    }

    public class ProductManualMap
    {
        public ProductManualMap(EntityTypeBuilder<ProductManual> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x =>x.Id);
            entityTypeBuilder.HasOne(x=>x.Product).WithOne(x=>x.ProductManual).HasForeignKey<ProductManual>(x=>x.ProductId);
            entityTypeBuilder.Property(x => x.ManualName);
        }
    }
}
