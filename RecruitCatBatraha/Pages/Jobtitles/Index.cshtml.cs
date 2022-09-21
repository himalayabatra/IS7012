using System;
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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatBatraha.Data.RecruitCatBatrahaContext _context;

        public IndexModel(RecruitCatBatraha.Data.RecruitCatBatrahaContext context)
        {
            _context = context;
        }

        public IList<Jobtitle> Jobtitle { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Jobtitle != null)
            {
                Jobtitle = await _context.Jobtitle.ToListAsync();
            }
        }
    }
}
