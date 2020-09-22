using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using JobHub.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JobHub.Controllers
{
    public class BaseController : Controller
    {
        
        public void Notify(string message, string title = "Sweet Alert Toastr Demo",
                                    NotificationType notificationType = NotificationType.success)
        {
            var msg = new
            {
                message = message,
                title = title,
                icon = notificationType.ToString(),
                type = notificationType.ToString(),
                provider = "toastr"
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);

        }
        public string GetLoggedInUserId(UserManager<ApplicationUser> userManager) => userManager.GetUserId(HttpContext.User);
        public string GetLoggedInUserEmail(UserManager<ApplicationUser> userManager) => userManager.GetUserName(HttpContext.User);
        

        private string GetProvider()
        {
           return "Ok";
        }
        public enum NotificationType
        {
            error,
            success,
            warning
        }
    }
}
