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
        private readonly UserManager<ApplicationUser> userManager;

        private readonly IUnitOfWork unitOfWork;

        public EmployeeController(ILogger<EmployeeController> logger,
        
        UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;
            this.userManager = userManager;
        }
        public string errorMessage = "Error occured while processing your request, Please try again";

        public IActionResult Index()
        {
              
            
            string userId = GetLoggedInUserId(userManager);
            //if user has not created a profile then redirect to create profile page
            if (!unitOfWork.employeeRepository.IsProfileGood(userId))
            {
                return View(nameof(CreateProfile));
            }
             return View(unitOfWork.employeeRepository.GetEmployeeProfile(userId));
        }
       
        public IActionResult CreateProfile()
        {
            string userId = GetLoggedInUserId(userManager);
            //check if user already has profile
            if (unitOfWork.employeeRepository.IsProfileGood(userId))
            {
                _logger.LogError("User has already created a profile");
                return NoContent();
            }


            return View();
        }
        [HttpPost]
        public IActionResult CreateProfile(EmployeeProfile e)
        {
            e.UserId = GetLoggedInUserId(userManager);
            unitOfWork.employeeRepository.CreateProfile(e);
            unitOfWork.Commit();
            
            return RedirectToAction(nameof(Index));
        }
        public IActionResult UpdateProfile(EmployeeProfile e)
        {
           
            unitOfWork.employeeRepository.UpdateProfile(e);
           
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdatePhoto(int id, IFormFile file)
        {
            try{
            await unitOfWork.employeeRepository.UpdatePhoto(id, file);
            unitOfWork.Commit();
            }
            catch{
                _logger.LogWarning(errorMessage);
                Notify(errorMessage,"Whoops!🐸", NotificationType.error);
            }

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> MyResume()
        {
            var user = GetLoggedInUserId(userManager);
            var view = await unitOfWork.myResumeRepository.GetMyResumeAsync(user);
            return View(view);

        }
        
        public IActionResult SetResumeObjective(MyResumeView v)
        {
            //Add if not set and Update if set
            unitOfWork.myResumeRepository.SetResumeObjective(v);
            return RedirectToAction("MyResume", "Employee");

        }
        public IActionResult SetKeySkill(MyResumeView v)
        {
            unitOfWork.myResumeRepository.SetKeySkill(v);
            return RedirectToAction("MyResume", "Employee");
        }
        public IActionResult SetEducation(MyResumeView v)
        {
           unitOfWork.myResumeRepository.SetEducation(v);
            unitOfWork.Commit();
            return RedirectToAction("MyResume", "Employee");
        }

        public IActionResult SetExperience(MyResumeView v)
        {
           
           unitOfWork.myResumeRepository.SetExperience(v);
           unitOfWork.Commit();
            return RedirectToAction("MyResume", "Employee");
        }
        public IActionResult SetSpecialization(MyResumeView v)
        {
            unitOfWork.myResumeRepository.SetSpecialization(v);
            unitOfWork.Commit();
            return RedirectToAction("MyResume", "Employee");
        }
        public IActionResult SetProfileSummary(MyResumeView v)
        {
           unitOfWork.myResumeRepository.SetProfileSummary(v);
           unitOfWork.Commit();
           return RedirectToAction("MyResume", "Employee");

        }
        public IActionResult SetJobPreference(MyResumeView v)
        {
            unitOfWork.myResumeRepository.SetJobPreference(v);
            unitOfWork.Commit();
            return RedirectToAction("MyResume", "Employee");

        }
        public IActionResult SavedJobs()
        {
            
            var userid = GetLoggedInUserId(userManager);
            int numberOfrows = 10;
            return View(unitOfWork.jobRepository.GetSavedJob(userid, numberOfrows).ToList());
        }
        public IActionResult AppliedJobs()
        {
            
            return View();
        }
        public IActionResult JobAlerts()
        {
            
            return View();
        }
        public IActionResult MyCv()
        {
            string userId = GetLoggedInUserId(userManager);
            var data = unitOfWork.myResumeRepository.GetMyCV(userId);
            if(data.GetType().GetProperties().All(x=>x.GetValue(data)!=null))
            {
            ViewBag.IsNull = false;
            }
            else
            {
            ViewBag.IsNull = true; 
            }
            return View(data);
            
        }





    }
}
