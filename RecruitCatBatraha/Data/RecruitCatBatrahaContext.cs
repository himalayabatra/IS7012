using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatBatraha.Models;

namespace RecruitCatBatraha.Data
{
    public class RecruitCatBatrahaContext : DbContext
    {
        public RecruitCatBatrahaContext (DbContextOptions<RecruitCatBatrahaContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatBatraha.Models.Candidate> Candidate { get; set; } = default!;

        public DbSet<RecruitCatBatraha.Models.Company> Company { get; set; }

        public DbSet<RecruitCatBatraha.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatBatraha.Models.Jobtitle> Jobtitle { get; set; }
    }
}
