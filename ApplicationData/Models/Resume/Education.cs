using System;
using System.ComponentModel.DataAnnotations;

namespace JobHub.Models.Resume
{
    public class Education
    {
        public int Id { get; set; }
          [MaxLength(256)]
        public string GraduatedDate  { get; set; }
          [MaxLength(256)]

        public string College { get; set; }
          [MaxLength(256)]
        public string University { get; set; }
          [MaxLength(256)]
        public string CourseTitle { get; set; }
          [MaxLength(256)]
        public string CGPA { get; set; }
         public EmployeeProfile EmployeeProfile {get;set;}
        public int EmployeeProfileId {get;set;}
    }
}