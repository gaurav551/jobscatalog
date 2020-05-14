using System;

namespace JobHub.Models
{
    public class SavedJobView
    {

        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public DateTime SavedOn { get; set; }
        public string UserId { get; set; }

    }
}