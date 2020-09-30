using System;
using System.Collections.Generic;

namespace JobHub.Models
{
    public class JobDetailsView
    {
        public Job Job {get;set;}
        public string TimeLeftForDeadline { get; set; }
        public string CompanyName {get;set;}
        public int CompanyId { get; set; }
        public string Logo {get;set;}
        public bool IsExpired { get; set; }
        public int ViewCount { get; set; }
        public DateTime CompanyFounded {get;set;}
        public List<string> Tags {get;set;}
        public bool IsApplied { get; set; }
        public DateTime AppliedDate { get; set; }
        public bool IsSaved { get; set; }
    }
}