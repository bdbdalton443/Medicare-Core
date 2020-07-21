using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Patients.NextOfKins
{
    public class IndexModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public IndexModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<NextOfKin> NextOfKin { get;set; }

        public async Task OnGetAsync()
        {
            NextOfKin = await _context.NextOfKins
                .Include(n => n.NOKRelationship).ToListAsync();
        }
    }
}
