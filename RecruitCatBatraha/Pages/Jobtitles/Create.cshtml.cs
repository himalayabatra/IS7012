using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatBatraha.Data;
using RecruitCatBatraha.Models;

namespace RecruitCatBatraha.Pages.Jobtitles
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatBatraha.Data.RecruitCatBatrahaContext _context;

        public CreateModel(RecruitCatBatraha.Data.RecruitCatBatrahaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Jobtitle Jobtitle { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Jobtitle.Add(Jobtitle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
