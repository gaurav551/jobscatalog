using System;
using System.Collections.Generic;
using System.Text;
using ApplicationData.Models;
using JobHub.Models;
using JobHub.Models.Resume;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobHub.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
               new IdentityRole { Id = "1", Name = "Employee", NormalizedName = "Employee".ToUpper() },
               new IdentityRole { Id = "2", Name = "Employer", NormalizedName = "Employer".ToUpper() },
               new IdentityRole { Id = "3", Name = "Admin", NormalizedName = "Admin".ToUpper() }

            );
        }
        
    }
    public static class UserInitializer
    {
        public static async System.Threading.Tasks.Task InitilizeAsync(UserManager<ApplicationUser> userManager)
        {
            string password = "jobscatalog551";
            //Create 3 Employers
            if(userManager.FindByEmailAsync("employer@gmail.com").Result==null)
            {
                
                List<ApplicationUser> user = new List<ApplicationUser>()
                {
                    new ApplicationUser(){
                   Email = "employer@gmail.com",
                   Id = "dab6f06c-72f8-4912-81b5-ebde1588c8be",
                   UserName = "employer@gmail.com",
                   IsEmployer = true
                    },
                    new ApplicationUser(){
                   Email = "employer2@gmail.com",
                   Id = "dab6f06c-72f8-4912-81b5-ebde1518c8be",
                   UserName = "employer2@gmail.com",
                   IsEmployer = true
                    },
                    new ApplicationUser(){
                   Email = "employer3@gmail.com",
                   Id = "dab6f06c-72f8-4912-81b5-ebde1388c8be",
                   UserName = "employer3@gmail.com",
                   IsEmployer = true
                    },
                   
                };
                foreach(var item in user)
                {
                var result = await userManager.CreateAsync(item,password);
                if(result.Succeeded)
                {
                   await userManager.AddToRoleAsync(item,"Employer");
                }
                }
            }
            //create employee
            if(userManager.FindByEmailAsync("employee@gmail.com").Result==null)
            {
               
                ApplicationUser user = new ApplicationUser()
                {
                   Email = "employee@gmail.com",
                   Id = "dab6f06c-72f8-4992-81b5-ebde1518c8be",
                   UserName = "employe@gmail.com",
                   IsEmployer = false
                   
                };

                var result = await userManager.CreateAsync(user,password);
                if(result.Succeeded)
                {
                   await userManager.AddToRoleAsync(user,"Employee");
                }
            }
            //create admin
            if(userManager.FindByEmailAsync("admin@jobscatalog.com").Result==null)
            {
                var user = new ApplicationUser()
                {
                    Id= Guid.NewGuid().ToString(),
                    Email = "admin@jobscatalog.com",
                    UserName = "admin@jobscatalog.com"

                };
                var create =  userManager.CreateAsync(user, password);
                if(create.Result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user,"Admin");
                }
            }

        }

    }
}
