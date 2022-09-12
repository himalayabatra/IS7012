namespace RecruitCatBatraha.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string? name { get; set; }
        public string? positionName { get; set; }
        public double minimumSalary { get; set; }
        public double maximumSalary { get; set; }
        public DateOnly startDate { get; set; }
        public string? location { get; set; }

        public Boolean? isFortune500 { get; set; }
    }
}
