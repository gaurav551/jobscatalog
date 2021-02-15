using System;
using System.Linq;
using JobHub.Data;
using JobHub.Models;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository;
using JobHub.Controllers;

namespace JobsCatalog.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class JobController : BaseController
    {
        private readonly ILogger<JobController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;

        public JobController(ILogger<JobController> logger,
        IUnitOfWork unitOfWork, ApplicationDbContext context,
        UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
            _context = context;
            _logger = logger;
            _unitOfWork = unitOfWork;

        }

        [HttpPost]
        public IActionResult GetJobs()
        
        {
           
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
                var jobs = (from job in _context.Jobs select job);
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
         public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult JobDetails(int id)
        {
            System.Console.WriteLine("Got");
            var a = _context.Jobs.FirstOrDefault(x => x.Id == id);
            ViewBag.details = a;

            return PartialView("_JobDetails");
        }
        public IActionResult Manage()
        {
           
            return View();
        }
    }
}