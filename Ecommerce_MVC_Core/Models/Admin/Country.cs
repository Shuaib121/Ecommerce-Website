using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PROG7311_TASK2.Models.Admin
{
    public class Country:BaseEntity
    {
        public string Name { get; set; }

        public  ICollection<City> Cities { get; set; }
    }

    public class CountryMap
    {
        public CountryMap(EntityTypeBuilder<Country> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Name);
        }
    }
}
