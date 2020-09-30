using JobHub.Data;
using JobHub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository;

namespace JobsCatalog.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;

        public AdminController(ILogger<AdminController> logger,
        IUnitOfWork unitOfWork, ApplicationDbContext context,
        UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
            _context = context;
            _logger = logger;
            _unitOfWork = unitOfWork;

        }

        public IActionResult Index()
        {
           
            return View();
        }
    }
}