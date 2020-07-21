﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;

namespace DemoHms.Pages.Bills.BillStatuses
{
    public class DeleteModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public DeleteModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BillStatus BillStatus { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BillStatus = await _context.BillStatus.FirstOrDefaultAsync(m => m.BillStatusID == id);

            if (BillStatus == null)
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

            BillStatus = await _context.BillStatus.FindAsync(id);

            if (BillStatus != null)
            {
                _context.BillStatus.Remove(BillStatus);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}