namespace ApplicationData.Models.ViewModels
{
    public class JobFilter
    {
        public string KeyWord { get; set; }
        public string Category { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public int Experience { get; set; }

    }
}