using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace DemoHms.Pages.HospitalEntity.Modules.Mappings
{
    public class IndexModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public IndexModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Mapping> Mapping { get;set; }

        public async Task OnGetAsync()
        {
            Mapping = await _context.Mappings
                .Include(m => m.Hospital)
                .Include(m => m.Module).ToListAsync();
        }
    }
}
