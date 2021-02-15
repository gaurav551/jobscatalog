using System;
using System.Collections.Generic;
using System.Linq;
using JobHub.Data;
using JobHub.Models;
using Repository;

namespace JobsCatalog.Areas.Admin.ViewModels
{
    public class AdminIndexView
    {
        public int JobCount { get; set; }
        public int EmployeeCount { get; set; }
        public int EmployerCount { get; set; }
        public int NewJobCount { get; set; }
        public int ResumeCount { get; set; }
        public int ExpiredJobCount { get; set; }
        public int AppliedJobCount { get; set; }

        public List<IndexView> IndexView { get; set; }
        private readonly IUnitOfWork unitOfWork;
        private readonly ApplicationDbContext context;
        public AdminIndexView(IUnitOfWork unitOfWork, ApplicationDbContext context)
        {
            this.context = context;
            this.unitOfWork = unitOfWork;
            JobCount = unitOfWork.jobRepository.BrowseJob().Count();
            NewJobCount = unitOfWork.jobRepository.BrowseJob().Where(x=>x.TimePosted.Year.Equals(DateTime.Now.Year) && x.TimePosted.Month == DateTime.Now.Month).Count();
            EmployeeCount = context.ApplicationUsers.Where(x=>!x.IsEmployer).Count();
            EmployerCount = context.ApplicationUsers.Where(x=>x.IsEmployer).Count();
            IndexView = unitOfWork.jobRepository.BrowseJob().OrderByDescending(x=>x.Id).Take(10).ToList();
            ResumeCount = context.EmployeeProfiles.Count();
            ExpiredJobCount = context.Jobs.Where(x=>x.Deadline<DateTime.Now).Count();
            AppliedJobCount = context.AppliedJobs.Count();


        }

    }
}