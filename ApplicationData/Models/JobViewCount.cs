using JobHub.Models;

namespace ApplicationData.Models
{
    public class JobViewCount
    {
        public int Id { get; set; }
        public Job Job { get; set; }
        public int JobId { get; set; }
        public int Count { get; set; }
    }
}