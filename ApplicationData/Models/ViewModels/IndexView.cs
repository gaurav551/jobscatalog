using System;
namespace JobHub.Models
{
    public class IndexView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public DateTime TimePosted { get; set; }
        public string Category { get; set; }
        public string PostedOn { get; set;}
        public string CompanyName { get; set; }
        public string Image { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
    }
}