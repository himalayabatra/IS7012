﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatBatraha.Data.RecruitCatBatrahaContext _context;

        public DeleteModel(RecruitCatBatraha.Data.RecruitCatBatrahaContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Candidate == null)
            {
                return NotFound();
            }
            var candidate = await _context.Candidate.FindAsync(id);

            if (candidate != null)
            {
                Candidate = candidate;
                _context.Candidate.Remove(Candidate);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
