using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBatraha.Data;
using RecruitCatBatraha.Models;

namespace RecruitCatBatraha.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatBatraha.Data.RecruitCatBatrahaContext _context;

        public IndexModel(RecruitCatBatraha.Data.RecruitCatBatrahaContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Candidate != null)
            {
                Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.Jobtitle).ToListAsync();
            }
        }
    }
}
