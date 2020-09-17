using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PROG7311_TASK2.Models.Admin
{
    public class ProductComments:BaseEntity
    {
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public string Comment { get; set; }

        public  Product Product { get; set; }
        public  ApplicationUsers Users { get; set; }
    }

    public class ProductCommentsMap
    {
        public ProductCommentsMap(EntityTypeBuilder<ProductComments> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Comment).HasMaxLength(200);
            entityTypeBuilder.HasOne(x => x.Product).WithMany(x => x.ProductCommentses).HasForeignKey(x => x.ProductId);
            entityTypeBuilder.HasOne(x => x.Users).WithMany(x => x.ProductCommentses).HasForeignKey(x => x.UserId);
        }
    }

}
