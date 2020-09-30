using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Repository
{
    public  static class GImageResizer
    {
        //
        // Summary:
        //     stores the profile file into memorystream and resize it into the prvided resolution
        //
        // Parameters:
        //   original:
        //    IFormFile , filename , Folder
        public static async Task ResizeImage(IFormFile file, string FileName, string folder)
        {
            using (var memoryStream = new MemoryStream())
            {
                var directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/"+folder);
                 Directory.CreateDirectory(directory);
                await file.CopyToAsync(memoryStream);
                Bitmap original = (Bitmap)Image.FromStream(memoryStream);
                //For Resize
                Bitmap processed = new Bitmap(original, new Size(300, 300));
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/"+folder, FileName);
                processed.Save(path);
                
            }
        } 
        
    }
}