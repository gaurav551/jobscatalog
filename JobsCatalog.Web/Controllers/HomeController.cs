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
using JobsCatalog.Seeder;
using Microsoft.AspNetCore.Identity;

namespace JobHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(ILogger<HomeController> logger,
        IUnitOfWork unitOfWork, ApplicationDbContext context,
        UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
            _context = context;
            _logger = logger;
            _unitOfWork = unitOfWork;

        }

        public async Task<IActionResult> Index()
        {
            //   var seeder = new Seeder(_context);

            // await seeder.SeedData();
             var stopwatch = new Stopwatch();
            stopwatch.Start();
            await UserInitializer.InitilizeAsync(userManager);
           

            
            ViewBag.totaljobs = _unitOfWork.jobRepository.BrowseJob().Count();
            stopwatch.Stop();
            System.Console.WriteLine($"Home page loaded in {stopwatch.Elapsed}");

            return View(_unitOfWork.jobRepository.BrowseJob().OrderBy(x=>x.Id).Take(35).ToList());
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


    }
}
