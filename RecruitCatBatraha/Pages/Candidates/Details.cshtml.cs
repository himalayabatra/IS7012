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
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatBatraha.Data.RecruitCatBatrahaContext _context;

        public DetailsModel(RecruitCatBatraha.Data.RecruitCatBatrahaContext context)
        {
            _context = context;
        }

      public Candidate Candidate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Candidate == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate.FirstOrDefaultAsync(m => m.CandidateId == id);
            if (candidate == null)
            {
                return NotFound();
            }
            else 
            {
                Candidate = candidate;
            }
            return Page();
        }
    }
}
