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
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
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
               new IdentityRole { Id = "2", Name = "Employer", NormalizedName = "Employer".ToUpper() }
            );
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<JobPreference> JobPreferences { get; set; }
        public DbSet<KeySkill> KeySkills { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<ProfileSummary> ProfileSummarys { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<AppliedJob> AppliedJobs { get; set; }
        public DbSet<Save> Saves {get;set;}
        public DbSet<JobViewCount> JobViewCounts { get; set; }
    }
}
