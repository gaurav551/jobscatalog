using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobHub.Models;
using JobHub.Data;
using System.Threading;
using Repository;

namespace JobHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,
        IUnitOfWork unitOfWork, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
            _unitOfWork = unitOfWork;

        }

        public async Task<IActionResult> IndexAsync()
        {
            
            await SeedData();

            var jobs = _unitOfWork.jobRepository.BrowseJob();
            ViewBag.totaljobs = jobs.Count();

            return View(jobs.Take(10).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public  Task SeedData()
        {
            if (!_context.Jobs.Any())
            {
                for (int i = 0; i < 1000; i++)
                {
                    Job j = new Job();

                    j.Location = "Kathmandu";
                    j.MaxSalary = 10000;
                    j.MinSalary = 9000;
                    j.Opening = 12;
                    j.Email = "aaa@@sss.oco";
                    j.PostedBy = "dab6f06c-72f8-4912-81b5-ebde1588c8be";
                    j.Title = "GGGGGGGG" + i;
                    j.PostedOn = DateTime.Now;
                    j.Tags = "mysql,dotnet-core,ASPNET-MVC";
                    j.Requirement = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk";
                    j.Responsibility = ";llllllllllllllllllllllllllllllllll";
                    j.Experience = 1212;
                    j.Category = "Hello";
                    j.Benefits = "vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv";
                    j.Type = "IT";
                    j.City = "Bhadrapur";
                    j.Location = "Jahaa";
                    j.Description = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
                    j.Deadline = DateTime.Now.AddMonths(10);
                    _context.Jobs.Add(j);
                    _context.SaveChanges();

                }
            }
            return Task.CompletedTask;
        }

    }
}
