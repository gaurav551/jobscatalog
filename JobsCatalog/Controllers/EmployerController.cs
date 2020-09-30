using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobHub.Models;
using JobHub.Data;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Drawing;
using ApplicationData.Models.ViewModels;
using Repository;
using Microsoft.EntityFrameworkCore;

namespace JobHub.Controllers
{
    [Authorize(Roles = "Employer")]
    public class EmployerController : BaseController
    {
        private readonly ILogger<EmployerController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        //private static string userId;
        private readonly IUnitOfWork _unitOfWork;

        public EmployerController(ILogger<EmployerController> logger,
        ApplicationDbContext context, UserManager<ApplicationUser> userManager,
        IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _userManager = userManager;
            _logger = logger;

        }
        


        public IActionResult Index()
        {
            var userId = GetLoggedInUserId(_userManager);



            var company = _context.Companies.FirstOrDefault(x => x.UserId.Equals(userId));

            if (company == null)
            {
                return RedirectToAction(nameof(NewCompany));
            }
           return View(company);
          

        }
        public IActionResult NewCompany()
        {
            ViewBag.Email = GetLoggedInUserEmail(_userManager);
            return View(new Company());
        }
        [HttpPost]
        public async Task<IActionResult> CreateCompany(Company company, IFormFile file)
        {
           
            company.UserId = GetLoggedInUserId(_userManager);
            await _unitOfWork.employerRepository.CreateCompanyAsync(company,file);
            _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(Company c)
        {
            //Update Any Class
            _context.Companies.Update(c);
            _context.SaveChanges();
            return RedirectToAction("Index", "Employer");
        }
        public async Task<IActionResult> UpdatePhoto(int id, IFormFile file)
        {
            await _unitOfWork.employerRepository.UpdatePhoto(id, file);


            return RedirectToAction(nameof(Index));
        }

        public IActionResult NewJob()
        {
            var userId = GetLoggedInUserId(_userManager);
            var email = _context.Companies.FirstOrDefault(x => x.UserId.Equals(userId)).Email;
            ViewBag.email = email;

            return View();
        }
        public IActionResult CreateJob(Job j)
        {
            j.PostedBy = GetLoggedInUserId(_userManager);
           
            _unitOfWork.jobRepository.Create(j);
            _unitOfWork.Commit();

            Notify("New Job is Created", "Success", NotificationType.success);

            return RedirectToAction("ManageJobs", "Employer");
        }
        public IActionResult ManageJobs()
        {


            return View();
        }
        [HttpPost]
        public IActionResult GetJobs()
        {
            System.Console.WriteLine("Hyy guy");
            string user = GetLoggedInUserId(_userManager);
            try
            {
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;
                var jobs = (from job in _context.Jobs where job.PostedBy.Equals(user) select job);
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    jobs = jobs.OrderBy(sortColumn + " " + sortColumnDirection);
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    jobs = jobs.Where(m => m.Title.Contains(searchValue)
                                                || m.Tags.Contains(searchValue)
                                                || m.Description.Contains(searchValue)
                                                || m.Requirement.Contains(searchValue));
                }
                recordsTotal = jobs.Count();
                var data = jobs.Skip(skip).Take(pageSize).OrderByDescending(x=>x.PostedOn).ToList();
                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Ok(jsonData);

            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpGet]
        public IActionResult EditJob(int id)
        {
            return View(_context.Jobs.FirstOrDefault(x => x.Id == id));
        }
        [HttpPost]
        public IActionResult EditJob(Job j)
        {
            j.Tags = j.Tags.Replace(" ",String.Empty);
            System.Console.WriteLine(j.Tags);
            
           _unitOfWork.jobRepository.Update(j);
           _unitOfWork.Commit();
            Notify("JOb Edited Successfully", "Success", NotificationType.success);

            return RedirectToAction("ManageJobs", "Employer");

        }
        public IActionResult DeleteJob(int id)
        {
            
           _unitOfWork.jobRepository.Remove(x=>x.Id==id);
           _unitOfWork.Commit();
            return RedirectToAction(nameof(ManageJobs));
        }
        public IActionResult JobDetails(int id)
        {
            var a = _context.Jobs.FirstOrDefault(x => x.Id == id);
            ViewBag.details = a;

            return PartialView("_JobDetails");
        }
        public async Task<IActionResult> Applicants(int? page)
        {
            string jobPosterUserId = GetLoggedInUserId(_userManager);
            IQueryable<ApplicantsView> applicants = _unitOfWork.employerRepository.GetApplicants(jobPosterUserId);
            int pageSize = 20;
            var data =  await PaginatedList<ApplicantsView>.CreateAsync(applicants.AsNoTracking().OrderByDescending(t => t.AppliedDate), page ?? 1, pageSize);
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
