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
using Repository;

namespace JobHub.Controllers
{
    [Authorize(Roles="Employee")]
    public class EmployeeController : BaseController
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;

        private readonly IUnitOfWork unitOfWork;

        public EmployeeController(ILogger<EmployeeController> logger,
        ApplicationDbContext context,
        UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

            _logger = logger;
            _context = context;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            
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
            var fileName = employee.Fullname + id + file.FileName;
            await ResizeUserImage(file, fileName);
            employee.PhotoUrl = fileName;
            _context.EmployeeProfiles.Update(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> MyResume()
        {
            var user = userManager.GetUserId(HttpContext.User);
            var view = await unitOfWork.myResumeRepository.GetMyResumeAsync(user);
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
            
            var userid = userManager.GetUserId(HttpContext.User);


            return View(unitOfWork.jobRepository.GetSavedJob(userid, 1, 10));
        }
        public IActionResult AppliedJobs()
        {
            
            return View();
        }
        public IActionResult JobAlerts()
        {
            
            return View();
        }
        public async Task<IActionResult> MyCv()
        {
            
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
