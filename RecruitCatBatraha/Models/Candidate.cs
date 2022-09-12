namespace RecruitCatBatraha.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }

        public double? targetSalary { get; set; }

        public DateOnly startDate { get; set; }

        public decimal experience { get; set; }

        public string? skills { get; set; }

    }
}
