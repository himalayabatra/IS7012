namespace RecruitCatBatraha.Models
{
    public class Jobtitle
    {
        public int jobtitleId { get; set; }

        public string? title { get; set; }
        public double minimumSalary { get; set; }
        public double maximumSalary { get; set; }

        public int? jobOpenings { get; set; }

        public string? requiredSkills { get; set; }
    }
}
