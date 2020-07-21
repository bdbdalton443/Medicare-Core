using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Lab.Statuses
{
    public class EditModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public EditModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ExaminationStatus ExaminationStatus { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ExaminationStatus = await _context.ExaminationStatuses.FirstOrDefaultAsync(m => m.ExaminationStatusID == id);

            if (ExaminationStatus == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ExaminationStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExaminationStatusExists(ExaminationStatus.ExaminationStatusID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExaminationStatusExists(int id)
        {
            return _context.ExaminationStatuses.Any(e => e.ExaminationStatusID == id);
        }
    }
}
