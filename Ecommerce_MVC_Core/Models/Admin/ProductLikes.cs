using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PROG7311_TASK2.Models.Admin
{
    public class ProductLikes
    {
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public DateTime AddedDate { get; set; }

        public  Product Product { get; set; }
        public  ApplicationUsers Users { get; set; }
    }
    
    public class ProductLikesMap
    {
        public ProductLikesMap(EntityTypeBuilder<ProductLikes> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => new {x.ProductId,x.UserId});
            entityTypeBuilder.Property(x => x.AddedDate).HasDefaultValue(DateTime.Now);
            }
    }
}
