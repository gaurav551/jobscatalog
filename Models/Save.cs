using System;

namespace JobHub.Models
{
    public class Save
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int JobId { get; set; }
        public DateTime SavedOn { get; set; } = DateTime.Now;
    }
}