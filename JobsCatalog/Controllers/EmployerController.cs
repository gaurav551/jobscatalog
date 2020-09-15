using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobHub.Models;
using JobHub.Data;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Drawing;
using ApplicationData.Models.ViewModels;

namespace JobHub.Controllers
{
    [Authorize(Roles="Employer")]
    public class EmployerController : BaseController
    {
        private readonly ILogger<EmployerController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        //private static string userId;

        public EmployerController(ILogger<EmployerController> logger,
        ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
           // userId = _userManager.GetUserId(HttpContext.User);
        }
        

        public IActionResult Index()
        {
             var userId = _userManager.GetUserId(HttpContext.User);
           
            
           
            var company = _context.Companies.FirstOrDefault(x => x.UserId.Equals(userId));

            if (company == null)
            {
                return RedirectToAction(nameof(NewCompany));
            }
            return View(company);

        }
        public IActionResult NewCompany()
        {
            ViewBag.Email = _userManager.GetUserName(HttpContext.User);
            return View(new Company());
        }
        [HttpPost]
        public async Task<IActionResult> CreateCompany(Company company, IFormFile file)
        {
            var fileName = company.CompanyName + company.Id + file.FileName;
            await ResizeImage(file, fileName);
            company.Logo = fileName;
            company.UserId = _userManager.GetUserId(HttpContext.User);
            _context.Companies.Add(company);
            await  _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(Company c)
        {
            _context.Companies.Update(c);
            _context.SaveChanges();
            return RedirectToAction("Index", "Employer");
        }
        public async Task<IActionResult> UpdatePhoto(int id, IFormFile file)
        {
            var company = _context.Companies.FirstOrDefault(x => x.Id == id);
            var image = company.Logo;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/companies", image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            var fileName = company.CompanyName + id + file.FileName;
            await ResizeImage(file, fileName);
            company.Logo = fileName;
            _context.Companies.Update(company);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult NewJob()
        {
             var userId = _userManager.GetUserId(HttpContext.User);
            
            

            var email = _context.Companies.FirstOrDefault(x => x.UserId.Equals(userId)).Email;
            ViewBag.email = email;

            return View();
        }
        public IActionResult CreateJob(Job j)
        {
           
              
            j.PostedBy = _userManager.GetUserId(HttpContext.User);
            _context.Jobs.Add(j);
            _context.SaveChanges();
            
            Notify("New Job is Created", "Success", NotificationType.success);

            return RedirectToAction("ManageJobs", "Employer");
        }
        public IActionResult ManageJobs()
        {
            
            var user = _userManager.GetUserId(HttpContext.User);
            var jobs = _context.Jobs.Where(x => x.PostedBy.Equals(user)).OrderByDescending(x => x.PostedOn).ToList();
            return View(jobs);
        }
        public IActionResult JobDetails(int id)
        {
            var a = _context.Jobs.FirstOrDefault(x => x.Id == id);
            ViewBag.details = a;

            return PartialView("_JobDetails");
        }
        public IActionResult DeleteJob(int id)
        {

            return Ok();
        }
        public IActionResult Applicants()
        {
            string userId = _userManager.GetUserId(HttpContext.User);
            var applicants = (from a in _context.AppliedJobs join c in _context.Jobs on a.JobPostedBy equals 
            c.PostedBy select new ApplicantsView()
            {
                JobPostedBy = c.PostedBy,
                JobTitle = _context.Jobs.FirstOrDefault(p=>p.Id==a.JobId).Title,
                ApplicantsName = _context.EmployeeProfiles.FirstOrDefault(x=>x.UserId.Equals(a.UserId)).Fullname,
                AppliedDate = a.AppliedDate,


            }).Where(a=>a.JobPostedBy.Equals(userId)).Take(50).OrderByDescending(x=>x.AppliedDate).ToList();
            return View(applicants);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
