using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoHms;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Finance.Billing.Bills
{
    public class EditModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public EditModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Bill Bill { get; set; }
        public Hospital Hospital { get; set; }
        public string ReceiptNumber { get; set; }
        [BindProperty]
        public ReceiptRoutine ReceiptRoutine { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bill = await _context.Bills
                .Include(b => b.BillStatus)
                .Include(b => b.Patient).FirstOrDefaultAsync(m => m.BIllID == id);
            Bill.Receipts = _context.Receipts.Include(I=>I.Treatment.Item).Include(I => I.Procedure.Test)
                .Where(m => m.BillID == id).ToList();

            var user = _context.AppUsers.Include(H=>H.Hospital).FirstOrDefault(A=>A.Email==User.Identity.Name);
            Hospital = user.Hospital;

            if (Bill == null)
            {
                return NotFound();
            }
           ViewData["BillStatusID"] = new SelectList(_context.BillStatus, "BillStatusID", "Name");
           ViewData["PatientID"] = new SelectList(_context.Patients, "PatientID", "FullName");
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
            ReceiptRoutine rrc = new ReceiptRoutine();
            rrc.Amount = ReceiptRoutine.Amount;
            rrc.BillID = Bill.BIllID;
            rrc.Description = ReceiptRoutine.Description;
            rrc.ReceiptNumber = ReceiptNumber;
            _context.ReceiptRoutines.Add(rrc);
            _context.SaveChanges();

            Bill.Balance = Bill.Total - _context.ReceiptRoutines.Where(RR => RR.BillID == Bill.BIllID).Sum(R => R.Amount);
           
            _context.Attach(Bill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillExists(Bill.BIllID))
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

        private bool BillExists(int id)
        {
            return _context.Bills.Any(e => e.BIllID == id);
        }
    }
}
