using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PROG7311_TASK2.Models.Admin
{
    public class Unit:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }

    public class UnitMap
    {
        public UnitMap(EntityTypeBuilder<Unit> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Name).HasMaxLength(100);
            entityTypeBuilder.Property(x => x.Description).HasMaxLength(200);
        }
    }
}
