using System;

namespace JobHub.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string PostedBy { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Tags { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public char Status { get; set; }
        public int Opening { get; set; }

        public int Experience { get; set; }
        public string MinSalary { get; set; }
        public string MaxSalary { get; set; }

        public string Description { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public DateTime Deadline { get; set; }
        public string Requirement { get; set; }
        public string Responsibility { get; set; }
        public string  Benefits { get; set; }
        public DateTime PostedOn { get; set; } = DateTime.Now;
    }
}