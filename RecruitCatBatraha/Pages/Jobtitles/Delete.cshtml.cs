﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBatraha.Data;
using RecruitCatBatraha.Models;

namespace RecruitCatBatraha.Pages.Jobtitles
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatBatraha.Data.RecruitCatBatrahaContext _context;

        public DeleteModel(RecruitCatBatraha.Data.RecruitCatBatrahaContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Jobtitle Jobtitle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Jobtitle == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.Jobtitle.FirstOrDefaultAsync(m => m.jobtitleId == id);

            if (jobtitle == null)
            {
                return NotFound();
            }
            else 
            {
                Jobtitle = jobtitle;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Jobtitle == null)
            {
                return NotFound();
            }
            var jobtitle = await _context.Jobtitle.FindAsync(id);

            if (jobtitle != null)
            {
                Jobtitle = jobtitle;
                _context.Jobtitle.Remove(Jobtitle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
