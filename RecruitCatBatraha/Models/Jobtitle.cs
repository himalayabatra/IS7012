using System.ComponentModel.DataAnnotations;

namespace RecruitCatBatraha.Models
{
    public class Jobtitle
    {
        public int jobtitleId { get; set; }

        [System.ComponentModel.DisplayName("Job Title")]
        [Required(ErrorMessage = "Job Title required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Maximum 30 characters")]
        public string? title { get; set; }

        [System.ComponentModel.DisplayName("Minimum Salary")]
        public double minimumSalary { get; set; }

        [System.ComponentModel.DisplayName("Maximum Salary")]
        public double maximumSalary { get; set; }

        [System.ComponentModel.DisplayName("Openings")]
        public int? jobOpenings { get; set; }

        [System.ComponentModel.DisplayName("Required Skills")]
        [Required(ErrorMessage = "Skills required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Maximum 60 characters")]
        public string? requiredSkills { get; set; }

        public List<Candidate>? Candidates { get; set; }
    }
}
