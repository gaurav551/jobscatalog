using System;
using System.ComponentModel.DataAnnotations;

namespace JobHub.Models.Resume
{
    public class Experience
    {
        public int Id { get; set; }
          [MaxLength(256)]
        public string WorkTitle { get; set; }
          [MaxLength(256)]
        public string CompanyName { get; set; }
          [MaxLength(256)]
        public string CompanyAddress { get; set; }
          [MaxLength(2000)]
        public string Responsibility { get; set; }
          [MaxLength(256)]
        public string FromYear { get; set; }
          [MaxLength(256)]
         public string FromMonth { get; set; }
           [MaxLength(256)]
        public string ToYear { get; set; }
          [MaxLength(256)]
        public string ToMonth { get; set; }
         public EmployeeProfile EmployeeProfile {get;set;}
        public int EmployeeProfileId {get;set;}

    }
}