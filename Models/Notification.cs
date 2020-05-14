using System;

namespace JobHub.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string NotificationMessage { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; } = false;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}