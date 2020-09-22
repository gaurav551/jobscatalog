using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobHub.Models;
using JobHub.Data;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Authorization;

using Repository;
using ApplicationData.Models.ViewModels;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace JobHub.Controllers
{
    public class JobController : BaseController
    {
        private readonly ILogger<JobController> _logger;
       
        private readonly UserManager<ApplicationUser> user;
        private readonly IUnitOfWork _unitOfWork;

        public JobController(ILogger<JobController> logger,
      
        UserManager<ApplicationUser> user,
        IUnitOfWork unitOfWork
        )
        {
            this.user = user;
            _unitOfWork = unitOfWork;
           _logger = logger;
        
        }

        public async Task<IActionResult> JobDetails(int id, string jobtitle)
        {
            var userId = user.GetUserId(HttpContext.User);
            var v =  await _unitOfWork.jobRepository.GetJobDetailsAsync(userId, id);
            return View(v);
        }
        public async Task<IActionResult> Tags(int? page, string tag)
        {
            var jobs = _unitOfWork.jobRepository.BrowseJob();
            int pageSize = 20;
            var data =  await PaginatedList<IndexView>.CreateAsync(jobs.Where(x=>x.Tag.Contains(tag)).AsNoTracking().OrderByDescending(t => t.Id), page ?? 1, pageSize);
            ViewBag.Tag = tag;
            
            ViewBag.SimilarTags = _unitOfWork.jobRepository.GetSimilarTags(tag);
            ViewBag.PopularTags  = _unitOfWork.jobRepository.GetPopularTags(); 
            return View(data);
        }
       
        [HttpGet]

         public IActionResult Save(int jobId)
        {
            System.Console.WriteLine(jobId);
            var userId = user.GetUserId(HttpContext.User);
            if(userId==null)
            {
                return Json(new { success = false, responseText="Please login to save" });
            }
           string message = _unitOfWork.jobRepository.SaveJob(jobId, userId);
           _unitOfWork.Commit();
           System.Console.WriteLine(message);
            return Json(new { success = true, responseText=message });
        }
        [Authorize]
        public async Task<IActionResult> ApplyJobAsync(int jobId)
        {
            var userId = await user.GetUserAsync(User);
            if(!_unitOfWork.employeeRepository.IsProfileGood(userId.Id))
            { 
                Notify("Create Your Profile and Apply","OOOPS!",NotificationType.error);
                ViewBag.Message = "Please Create your profile 😂😂😂";
              return RedirectToAction(nameof(JobDetails),new {id = jobId });
            }
            _unitOfWork.jobRepository.Apply(jobId, userId.Id);
            _unitOfWork.Commit();


            return RedirectToAction(nameof(JobDetails),new {id = jobId });
        }
        [HttpGet]
        public async Task<IActionResult> Browse(int? page,string keyword=null)
        {
            var jobs = _unitOfWork.jobRepository.BrowseJob();
            ViewBag.totaljobs = jobs.Count();
             int pageSize = 20;
            if(keyword!=null)
             {
                ViewBag.KeyWord = keyword;
                 return View(await PaginatedList<IndexView>.CreateAsync(jobs.Where(x=>x.Title.Contains(keyword)).AsNoTracking().OrderByDescending(t => t.Id), page ?? 1, pageSize));
             }  
            
            var data =  await PaginatedList<IndexView>.CreateAsync(jobs.AsNoTracking().OrderByDescending(t => t.Id), page ?? 1, pageSize);

            return View(data);
        }
        [HttpGet]
        public IActionResult JobFilter(string keyword=null,string category=null, string salary=null, int experience=0)
        {   
         
            System.Console.WriteLine($"Go Me {keyword} with {category} and sal{salary}");
              
                int minsalary= new int();
                int  maxsalary=  new int();
                if(salary!=null)
                {
                   minsalary = Convert.ToInt32(salary.Split("-")[0]); //0 - 15000 = > 12000
                   maxsalary = Convert.ToInt32(salary.Split("-")[1]);
                }
            
                var job = _unitOfWork.jobRepository.GetBy(x=>(
               (string.IsNullOrEmpty(keyword) || x.Title.Contains(keyword) || x.Tags.Contains(keyword)) &&
               (string.IsNullOrEmpty(category) || x.Category.Contains(category)) &&
               ((experience==0) || x.Experience==experience) &&
                (string.IsNullOrEmpty(salary) || x.MinSalary>=minsalary && x.MaxSalary<=maxsalary)

               ));
                  System.Console.WriteLine($"Found {job.Count()} jobs");
                  return PartialView("_JobFilter",job.Take(50).ToList());
        }


    }
}
