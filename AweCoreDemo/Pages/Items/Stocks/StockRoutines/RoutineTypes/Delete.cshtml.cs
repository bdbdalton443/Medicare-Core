using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AweCoreDemo.Data;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Items.Stocks.StockRoutines.RoutineTypes
{
    public class DeleteModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DeleteModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RoutineType RoutineType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RoutineType = await _context.RoutineType.FirstOrDefaultAsync(m => m.RoutineTypeID == id);

            if (RoutineType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RoutineType = await _context.RoutineType.FindAsync(id);

            if (RoutineType != null)
            {
                _context.RoutineType.Remove(RoutineType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
