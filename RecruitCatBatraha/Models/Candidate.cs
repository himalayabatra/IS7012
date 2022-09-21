using RecruitCatBatraha.Migrations;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatBatraha.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }

        [System.ComponentModel.DisplayName("First Name")]
        [Required(ErrorMessage = "First Name required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Maximum 30 characters")]
        public string? firstName { get; set; }

        [System.ComponentModel.DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Maximum 30 characters")]
        public string? lastName { get; set; }

        [System.ComponentModel.DisplayName("Expected Salary")]
        [Range(1000, 1000000)]
        public double? targetSalary { get; set; }

        [DataType(DataType.Date)]
        [System.ComponentModel.DisplayName("Date of Joining")]

        public DateTime startDate { get; set; }

        [System.ComponentModel.DisplayName("Experience")]
        [Range(1, 10)]

        public decimal experience { get; set; }

        [System.ComponentModel.DisplayName("Skills")]

        public string? skills { get; set; }

        public Company? Company { get; set; }

        [System.ComponentModel.DisplayName("Company Name")]
        public int? CompanyId { get; set; }
        public Jobtitle? Jobtitle { get; set; }

        [System.ComponentModel.DisplayName("Job Title")]
        public int? JobtitleId { get; set; }
        public Industry? Industry { get; set; }

        [System.ComponentModel.DisplayName("Industry")]
        public int? IndustryID { get; set; }
    }
}
