using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoHms.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoHms.Pages.HospitalEntity
{
    public class CreateModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public CreateModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Hospital> Hospitals { get; set; }
        public IActionResult OnGet()
        {
            Hospitals =  _context.Hospitals
                .Include(h => h.EntityType)
                .Include(h => h.Status).ToList();

            ViewData["EntityTypeID"] = new SelectList(_context.EntityTypes, "EntityTypeID", "Name");
            ViewData["StatusID"] = new SelectList(_context.Statuses, "StatusID", "Name");
            return Page();
        }

        [BindProperty]
        public Hospital Hospital { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           //Hospital.Color= Request.Form["Hospital.Color"].ToString();
            _context.Hospitals.Add(Hospital);
            await _context.SaveChangesAsync();
            Hospitals = _context.Hospitals
                .Include(h => h.EntityType)
                .Include(h => h.Status).ToList();
            ViewData["EntityTypeID"] = new SelectList(_context.EntityTypes, "EntityTypeID", "Name");
            ViewData["StatusID"] = new SelectList(_context.Statuses, "StatusID", "Name");
            return Page();// return RedirectToPage("./Index");
        }
    }
}
