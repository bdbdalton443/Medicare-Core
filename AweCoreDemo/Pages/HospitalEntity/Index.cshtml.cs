using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace DemoHms.Pages.HospitalEntity
{
    public class IndexModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public IndexModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Hospital> Hospital { get;set; }

        public async Task OnGetAsync()
        {
            Hospital = await _context.Hospitals
                .Include(h => h.EntityType)
                .Include(h => h.Status).ToListAsync();
        }
    }
}
