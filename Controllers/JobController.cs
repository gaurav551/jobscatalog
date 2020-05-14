using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobHub.Models;
using JobHub.Data;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Authorization;
using JobHub.Repository;
using AspNetCore;

namespace JobHub.Controllers
{
    public class JobController : Controller
    {
        private readonly ILogger<JobController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> user;
        private readonly IJobRepository job;

        public JobController(ILogger<JobController> logger,
        ApplicationDbContext context,
        UserManager<ApplicationUser> user,
        IJobRepository _job)
        {
            this.user = user;
            job = _job;
            _logger = logger;
           _context = context;
        }

        public IActionResult JobDetails(int id)
        {
            var userid = user.GetUserId(HttpContext.User);
            JobDetailsView v = new JobDetailsView();
             var job = _context.Jobs.FirstOrDefault(x=>x.Id==id);
             v.Job = job;
            var company = _context.Companies.FirstOrDefault(x=>x.UserId.Equals(job.PostedBy));
            v.Logo = company.Logo;
            v.Tags = job.Tags.Split(',').ToList();
            v.CompanyName =  company.CompanyName;
            v.CompanyFounded = company.FoundedDate;
            v.IsApplied = _context.AppliedJobs.Any(x => x.UserId.Equals(userid) && x.JobId == id);
            v.IsSaved = _context.Saves.Any(x => x.UserId.Equals(userid) && x.JobId == id);


            return View(v);
        }
        [Authorize]
        [HttpGet]

         public IActionResult Save(int jobId)
        {
            System.Console.WriteLine(jobId);

            var userId = user.GetUserId(HttpContext.User);
            job.SaveJob(jobId, userId);
           return RedirectToAction(nameof(JobDetails),new {id = jobId });
        }
        [Authorize]
        public IActionResult ApplyJob(int jobId)
        {

            var userId = user.GetUserId(HttpContext.User);
            job.Apply(jobId, userId);


            return RedirectToAction(nameof(JobDetails),new {id = jobId });
        }
        public IActionResult Browse()
        {
            return View();
        }


    }
}
