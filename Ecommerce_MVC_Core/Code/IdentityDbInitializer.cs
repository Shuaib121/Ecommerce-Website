using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using PROG7311_TASK2.Models;
using Microsoft.AspNetCore.Identity;

namespace PROG7311_TASK2.Code
{
    public class IdentityDbInitializer
    {
        public static ApplicationDbContext _context;

        public IdentityDbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public static void SeedData(UserManager<ApplicationUsers> userManager,
            RoleManager<ApplicationRoles> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedUsers(UserManager<ApplicationUsers> userManager)
        {

            if (userManager.FindByNameAsync
                    ("user1").Result == null)
            {
                ApplicationUsers user = new ApplicationUsers
                {
                    UserName = "user1",
                    Email = "user1@localhost.com",
                    Name = "Bob Dob",
                    DateOfBirth = new DateTime(1999, 1, 1),
                    //CityId =cityId 
                };

                IdentityResult result = userManager.CreateAsync
                    (user, "password123").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,
                        "User").Wait();
                }
            }


            if (userManager.FindByNameAsync
                    ("admin").Result == null)
            {
                ApplicationUsers user = new ApplicationUsers
                {
                    UserName = "Shuaib121",
                    Email = "admin@localhost.com",
                    Name = "Shuaib Ebrahim",
                    DateOfBirth = new DateTime(1999, 1, 1),
                    //CityId = cityId
                };

                IdentityResult result = userManager.CreateAsync
                    (user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,
                        "Admin").Wait();
                }
            }
        }

        public static void SeedRoles(RoleManager<ApplicationRoles> roleManager)
        {
            if (!roleManager.RoleExistsAsync
                ("User").Result)
            {
                ApplicationRoles role = new ApplicationRoles
                {
                    Name = "User",
                    Description = "Perform normal operations."
                };
                IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync
                ("Admin").Result)
            {
                ApplicationRoles role = new ApplicationRoles
                {
                    Name = "Admin",
                    Description = "Perform all the operations."
                };
                IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync
                ("Editor").Result)
            {
                ApplicationRoles role = new ApplicationRoles
                {
                    Name = "Editor",
                    Description = "Can Edit  all the operations."
                };
                IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
            }
        }
    }
}
