using System.Linq;
using JobHub.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JobsCatalog.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly ILogger<CompanyController> _logger;
        public CompanyController(ApplicationDbContext context, ILogger<CompanyController> logger)
        {
            _logger = logger;
            this.context = context;

        }
        public IActionResult Index(int id)
        {
            var company = context.Companies.FirstOrDefault(x => x.Id == id);
            var userId = company.UserId;
            _logger.LogInformation("Index Page Of Company");
            ViewBag.Job = context.Jobs.Where(x => x.PostedBy.Equals(userId)).Take(8).OrderByDescending(x => x.PostedBy).ToList();
            return View(company);
        }
        public IActionResult Like(int id)
        {
            System.Console.WriteLine(id);


            //     // var userId = user.GetUserId(HttpContext.User);
            //     // if(userId==null)
            //     // {
            //         return Json(new { success = false, responseText="Please login to save" });
            //    string message = _unitOfWork.jobRepository.SaveJob(jobId, userId);
            //    _unitOfWork.Commit();
            //    System.Console.WriteLine(message);
            return Json(new { success = true, responseText = "You liked" });
        }



    }
}