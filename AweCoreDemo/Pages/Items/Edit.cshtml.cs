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
using System.Security.Claims;

namespace DemoHms.Pages.Items
{
    public class EditModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public EditModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Item = await _context.Items
                .Include(i => i.ItemUnit)
                .Include(i => i.ItemType).FirstOrDefaultAsync(m => m.ItemID == id);
            if (Item == null)
            {
                return NotFound();
            }
            ViewData["ItemTypeID"] = new SelectList(_context.ItemTypes, "ItemTypeID", "Name");
            ViewData["ItemUnitID"] = new SelectList(_context.ItemUnits, "ItemUnitID", "Name");
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
            var bi = _context.BillItems.FirstOrDefault(B => B.ItemID == Item.ItemID);
            if (bi != null)
                Item.ExtendedName = Item.Name + " " + bi.Cost + "/=";
            var item = _context.Items.AsNoTracking().FirstOrDefault(I=>I.ItemID==Item.ItemID);
            try
            {

                var user = _context.AppUsers.FirstOrDefault(U=>U.Email==User.Identity.Name);
                    Item.ModifiedByUserId = user.Id;
                if (item.ApplicationUserId == null)
                    Item.ApplicationUserId = user.Id;

                _context.Items.Attach(Item).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(Item.ItemID))
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

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.ItemID == id);
        }
    }
}
