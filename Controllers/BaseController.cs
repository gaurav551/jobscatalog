using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobHub.Controllers
{
    public class BaseController : Controller
    {
        public async Task ResizeImage(IFormFile file, string FileName)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                Bitmap original = (Bitmap)Image.FromStream(memoryStream);
                //For Resize
                Bitmap processed = new Bitmap(original, new Size(300, 300));
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/companies", FileName);
                processed.Save(path);
                memoryStream.Flush();
            }
        }
        public async Task ResizeUserImage(IFormFile file, string FileName)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                Bitmap original = (Bitmap)Image.FromStream(memoryStream);
                //For Resize
                Bitmap processed = new Bitmap(original, new Size(300, 300));
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/employee", FileName);
                processed.Save(path);
                memoryStream.Flush();
            }

        }
    }
}
