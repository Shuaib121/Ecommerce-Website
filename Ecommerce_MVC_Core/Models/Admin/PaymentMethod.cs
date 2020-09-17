using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PROG7311_TASK2.Models.Admin
{
    public class PaymentMethod:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Processor { get; set; }

        public  ICollection<Orders> Orderses { get; set; }
        
    }

    public class PaymentMethodMap
    {
        public PaymentMethodMap(EntityTypeBuilder<PaymentMethod> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Name);
            entityTypeBuilder.Property(x => x.Description);
            entityTypeBuilder.Property(x => x.Processor);
        }
    }
}
