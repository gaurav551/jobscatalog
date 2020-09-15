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

namespace JobHub.Controllers
{
    public class JobController : BaseController
    {
        private readonly ILogger<JobController> _logger;
       
        private readonly UserManager<ApplicationUser> user;
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<ApplicationUser> signInManager;

        public JobController(ILogger<JobController> logger,
      
        UserManager<ApplicationUser> user,
        IUnitOfWork unitOfWork,
        SignInManager<ApplicationUser> signInManager)
        {
            this.user = user;
            _unitOfWork = unitOfWork;
            this.signInManager = signInManager;
            _logger = logger;
        
        }

        public async Task<IActionResult> JobDetails(int id, string jobtitle)
        {
            var userId = user.GetUserId(HttpContext.User);
            
            var v =  await _unitOfWork.jobRepository.GetJobDetailsAsync(userId, id);


            return View(v);
        }
        [Authorize]
        [HttpGet]

         public IActionResult Save(int jobId)
        {
            System.Console.WriteLine(jobId);

            var userId = user.GetUserId(HttpContext.User);
            _unitOfWork.jobRepository.SaveJob(jobId, userId);
            return Json(new { success = true });
        }
        [Authorize]
        public async Task<IActionResult> ApplyJobAsync(int jobId)
        {

            var userId = await user.GetUserAsync(User);
          
           
            _unitOfWork.jobRepository.Apply(jobId, userId.Id);
            _unitOfWork.Commit();


            return RedirectToAction(nameof(JobDetails),new {id = jobId });
        }
        [HttpGet]
        public IActionResult Browse(string keyword=null)
        {
            var jobs = _unitOfWork.jobRepository.BrowseJob();
            ViewBag.totaljobs = jobs.Count();
            if(keyword!=null)
             {
                ViewBag.KeyWord = keyword;
                 return View(jobs.Where(x=>x.Title.Contains(keyword)).Take(10).ToList());
             }  

            return View(jobs.Take(10).ToList());
        }
        [HttpGet]
        public IActionResult JobFilter(string keyword,string category, int minsalary, int maxsalary, int experience)
        {
            System.Console.WriteLine($"Go Me {keyword} with {category}");
            
            var result = _unitOfWork.jobRepository.GetBy(x=>(
               string.IsNullOrEmpty(keyword) || x.Title.Contains(keyword) || x.Tags.Contains(keyword) 
               && string.IsNullOrEmpty(category) || x.Category.Equals(category)
               && minsalary>1 || x.MinSalary>minsalary 
                && maxsalary>1 || x.MaxSalary<maxsalary 
                && experience>1 || x.Experience==experience));
                System.Console.WriteLine($"Found {result.Count()} jobs");
            return PartialView("_JobFilter",result.ToList());
        }


    }
}
