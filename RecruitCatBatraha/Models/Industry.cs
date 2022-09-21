using System.ComponentModel.DataAnnotations;

namespace RecruitCatBatraha.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }

        [System.ComponentModel.DisplayName("Industry Name")]
        [Required(ErrorMessage = "Industry Name required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Maximum 30 characters")]

        public string? IndustryName { get; set; }

        [System.ComponentModel.DisplayName("Industry Domain")]
        [Required(ErrorMessage = "Industry Domain required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Maximum 30 characters")]

        public string? IndustryDomain { get; set; }

        [System.ComponentModel.DisplayName("Industry Description")]
        [Required(ErrorMessage = "Industry Description required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Maximum 30 characters")]

        public string? IndustryDescription { get; set; }

        [System.ComponentModel.DisplayName("Average Salary")]

        public decimal? AverageSalary { get; set; }
        public List<Candidate>? Candidates { get; set; }
        public List<Company>? Companies { get; set; }
    }
}
