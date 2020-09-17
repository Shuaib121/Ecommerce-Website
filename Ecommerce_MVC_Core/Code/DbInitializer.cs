using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using PROG7311_TASK2.Models.Admin;

namespace PROG7311_TASK2.Code
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Countries.Any())
            {
                var country = new Country[]
                {
                    new Country{Name = "South Africa",AddedDate = DateTime.Parse("2020-07-19"),ModifiedDate = DateTime.Parse("2020-07-19")},
                };
                foreach (Country c in country)
                {
                    context.Countries.Add(c);
                }
                context.SaveChanges();
            }

            if (!context.Cities.Any())
            {
                var coutryId = context.Countries.First(x=>x.Name=="Bangladesh").Id;
                var city = new City[]
                {
                    new City{Name = "Durban",CountryId = coutryId,AddedDate = DateTime.Parse("2020-07-19"),ModifiedDate = DateTime.Parse("2020-07-19")},
                    new City{Name = "Cape Town",CountryId = coutryId,AddedDate = DateTime.Parse("2020-07-19"),ModifiedDate = DateTime.Parse("2020-07-19")},
                    new City{Name = "Johannesburg",CountryId = coutryId,AddedDate = DateTime.Parse("2020-07-19"),ModifiedDate = DateTime.Parse("2020-07-19")},
                };
                foreach (City c in city)
                {
                    context.Cities.Add(c);
                }
                context.SaveChanges();
            }


        }
    }
}
