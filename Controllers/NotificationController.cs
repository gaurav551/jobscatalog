using Microsoft.AspNetCore.Mvc;

namespace JobHub.Controllers
{
    public class NotidicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}