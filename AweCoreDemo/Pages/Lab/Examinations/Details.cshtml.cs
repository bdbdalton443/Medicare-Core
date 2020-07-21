using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Lab.Examinations
{
    public class DetailsModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DetailsModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Examination Examination { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Examination = await _context.Examinations
                .Include(e => e.Assignment)
                .Include(e => e.BillStatus)
                .Include(e => e.ExaminationStatus).FirstOrDefaultAsync(m => m.ExaminationID == id);

            if (Examination == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
