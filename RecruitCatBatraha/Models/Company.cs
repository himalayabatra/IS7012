using System.ComponentModel.DataAnnotations;

namespace RecruitCatBatraha.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        [System.ComponentModel.DisplayName("Company Name")]
        [Required(ErrorMessage = "Company Name required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Maximum 30 characters")]
        public string? name { get; set; }

        [System.ComponentModel.DisplayName("Position")]
        [Required(ErrorMessage = "Position required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Maximum 30 characters")]
        public string? positionName { get; set; }

        [System.ComponentModel.DisplayName("Minimum Salary")]
        [Range(1000, 100000)]
        public double minimumSalary { get; set; }

        [System.ComponentModel.DisplayName("Maximum Salary")]
        [Range(10000, 1000000)]
        public double maximumSalary { get; set; }

        [DataType(DataType.Date)]
        [System.ComponentModel.DisplayName("Date of Joining")]
        public DateTime startDate { get; set; }

        [System.ComponentModel.DisplayName("Location")]
        public string? location { get; set; }

        [System.ComponentModel.DisplayName("IsFortuneCompany")]
        public Boolean? isFortune500 { get; set; }

        public Industry? Industry { get; set; }

        [System.ComponentModel.DisplayName("Industry")]
        public int? IndustryID { get; set; }
        public List<Candidate>? Candidates { get; set; }

    }
}
