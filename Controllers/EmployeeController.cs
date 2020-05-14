using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobHub.Models;
using JobHub.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;
using JobHub.Models.Resume;
using Microsoft.EntityFrameworkCore;

namespace JobHub.Controllers
{
    [Authorize]
    public class EmployeeController : BaseController
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;

        public EmployeeController(ILogger<EmployeeController> logger,
        ApplicationDbContext context,
        UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            TempData["isactive1"] = "active";
            var user = userManager.GetUserId(HttpContext.User);
            if (!_context.EmployeeProfiles.Any(x => x.UserId.Equals(user)))
            {
                return View(nameof(CreateProfile));
            }


            return View(_context.EmployeeProfiles.FirstOrDefault(x => x.UserId.Equals(user)));
        }
        public IActionResult CreateProfile()
        {
            var user = userManager.GetUserId(HttpContext.User);
            if (_context.EmployeeProfiles.Any(x => x.UserId.Equals(user)))
            {
                return NoContent();
            }


            return View();
        }
        [HttpPost]
        public IActionResult CreateProfile(EmployeeProfile e)
        {
            e.UserId = userManager.GetUserId(HttpContext.User);
            _context.EmployeeProfiles.Add(e);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult UpdateProfile(EmployeeProfile e)
        {
            e.PhotoUrl = e.PhotoUrl;
            e.UserId = e.UserId;
            _context.EmployeeProfiles.Update(e);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdatePhoto(int id, IFormFile file)
        {
            var employee = _context.EmployeeProfiles.FirstOrDefault(x => x.Id == id);
            var image = employee.PhotoUrl;
            if (image != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/employee", image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }
            var fileName = employee.Fullname + id + file.FileName ;
            await ResizeUserImage(file, fileName);
            employee.PhotoUrl = fileName;
            _context.EmployeeProfiles.Update(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> MyResume()
        {
            var user = userManager.GetUserId(HttpContext.User);
            var employee = await _context.EmployeeProfiles.FirstOrDefaultAsync(x => x.UserId.Equals(user));
            var view = new MyResumeView();
            view.Id = employee.Id;
            view.Name = employee.Fullname;
            view.Address = employee.Address;
            view.City = employee.City;
            view.ProfessionalTitle = employee.ProfessionalTitle;
            view.Email = employee.Email;
            view.Phone = employee.Phone;
            view.PhotoUrl = employee.PhotoUrl;
            view.Objective = _context.Objectives.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.KeySkill = _context.KeySkills.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.Experience = _context.Experiences.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.Education = _context.Educations.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.Specialization = _context.Specializations.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.ProfileSummary = _context.ProfileSummarys.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            view.JobPreference = _context.JobPreferences.FirstOrDefault(x => x.EmployeeProfileId == employee.Id);
            return View(view);

        }
        public IActionResult SetResumeObjective(MyResumeView v)
        {
            var ob = v.Objective;
            var check = _context.Objectives.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                _context.Objectives.Add(ob);
            }
            else
            {
                _context.Objectives.Update(ob);
            }
              _context.SaveChanges();
              return RedirectToAction("MyResume", "Employee");

        }
        public IActionResult SetKeySkill(MyResumeView v)
        {
            var ob = v.KeySkill;
            var check = _context.KeySkills.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                _context.KeySkills.Add(ob);
            }
            else
            {
                _context.KeySkills.Update(ob);

            }
            _context.SaveChanges();
            return RedirectToAction("MyResume", "Employee");
        }
        public IActionResult SetEducation(MyResumeView v)
        {
            var ob = v.Education;
            var check = _context.Educations.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                _context.Educations.Add(ob);
            }
            else
            {
                _context.Educations.Update(ob);

            }
            _context.SaveChanges();
            return RedirectToAction("MyResume", "Employee");
        }

        public IActionResult SetExperience(MyResumeView v)
        {
            var ob = v.Experience;
            var check = _context.Experiences.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                _context.Experiences.Add(ob);
            }
            else
            {
                _context.Experiences.Update(ob);
            }
            _context.SaveChanges();
            return RedirectToAction("MyResume", "Employee");
        }
         public IActionResult SetSpecialization(MyResumeView v)
        {
            var ob = v.Specialization;
            var check = _context.Specializations.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                _context.Specializations.Add(ob);
            }
            else
            {
                _context.Specializations.Update(ob);
            }
            _context.SaveChanges();
            return RedirectToAction("MyResume", "Employee");
        }
        public IActionResult SetProfileSummary(MyResumeView v)
        {
             var ob = v.ProfileSummary;
            var check = _context.ProfileSummarys.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                _context.ProfileSummarys.Add(ob);
            }
            else
            {
                _context.ProfileSummarys.Update(ob);
            }
            _context.SaveChanges();
            return RedirectToAction("MyResume", "Employee");

        }
        public IActionResult SetJobPreference(MyResumeView v)
        {
             var ob = v.JobPreference;
            var check = _context.JobPreferences.AsNoTracking().FirstOrDefault(x => x.Id == ob.Id);
            if (check == null)
            {
                _context.JobPreferences.Add(ob);
            }
            else
            {
                _context.JobPreferences.Update(ob);
            }
            _context.SaveChanges();
            return RedirectToAction("MyResume", "Employee");

        }
        public IActionResult SavedJobs()
        {
            TempData["isactive2"] = "active";
            var userid = userManager.GetUserId(HttpContext.User);
             var savedjob = (from s  in _context.Saves
            join j in _context.Jobs on s.JobId equals j.Id
            select new SavedJobView()
            {
                  JobId = j.Id,
                  JobTitle = j.Title,
                  SavedOn = s.SavedOn,
                   UserId = s.UserId

            });

            return View(
                savedjob.Where(x=>x.UserId.Equals(userid)).Take(10).ToList()
                );
        }
        public IActionResult AppliedJobs()
        {
            TempData["isactive3"] = "active";
            return View();
        }
        public IActionResult JobAlerts()
        {
            TempData["isactive4"] = "active";
            return View();
        }
        public async Task<IActionResult> MyCv()
        {
             TempData["isactive5"] = "active";
            var user = userManager.GetUserId(HttpContext.User);
            var employee = await _context.EmployeeProfiles.FirstOrDefaultAsync(x => x.UserId.Equals(user));
            var view = new MyResumeView();
            view.Id = employee.Id;
            view.Name = employee.Fullname;
            view.Address = employee.Address;

            return View(view);
        }





    }
}
