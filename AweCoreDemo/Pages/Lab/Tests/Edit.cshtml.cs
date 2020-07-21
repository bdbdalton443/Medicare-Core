using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;
using DemoHms;
using AweCoreDemo.Data;
using Omu.AwesomeMvc;
using Omu.Awem.Utils;
using AweCoreDemo.ViewModels.Input;

namespace AweCoreDemo.Pages.Lab.Tests
{
    public class EditModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public EditModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Test Test { get; set; }
        public static Test TestClone { get; set; }
        public IQueryable<Test> Tests { get; set; }
        public IQueryable<Item> Items { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Test = await _context.Tests
                .Include(t => t.Department).FirstOrDefaultAsync(m => m.TestID == id);

            if (Test == null)
            {
                return NotFound();
            }
            Tests = _context.Tests.ToList().AsQueryable();
            Items = _context.Items.ToList().AsQueryable();
            TestClone = Test;
            ViewData["DepartmentID"] = new SelectList(_context.Departments, "DepartmentID", "Name");
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

            _context.Attach(Test).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestExists(Test.TestID))
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

        private bool TestExists(int id)
        {
            return _context.Tests.Any(e => e.TestID == id);
        }
        private object MapToGridModel(TestConsumable o)
        {
            Items = _context.Items.AsQueryable();
            Tests = _context.Tests.AsQueryable();
            Item item = null;
            Test test = null;
            if (o.ItemID != null)
                item = _context.Items.FirstOrDefault(I => I.ItemID == o.ItemID);
            if (o.TestID != null)
                test = _context.Tests.FirstOrDefault(I => I.TestID == o.TestID);
            return new
            {
                o.TestConsumableID,
                o.Quantity,
                Items = string.Join(", ", Items.Select(m => m.Name)),
                Tests = string.Join(", ", Tests.Select(m => m.Name)),
                Item = item != null ? item.Name : "",
                Test = test != null ? test.Name : "",
                //o.Organic,
                //DispOrganic = o.Organic ? "Yes" : "No",

                //// below properties used for inline editing only
                // ItemID = Items.Select(m => m.ItemID).ToArray(),
                //ChefId = o.Chef.Id,
                ItemID = o.Item != null ? o.Item.ItemID : 0,
                TestID = o.Test != null ? o.Test.TestID : 0
            };
        }

        public IActionResult OnPostGridGetItems(GridParams g, string search)
        {
            IQueryable<TestConsumable> items = null;
            search = (search ?? "").ToLower();

            if (TestClone == null)
                TestClone = Test;

            if (string.IsNullOrWhiteSpace(search))
            {
                items = _context.TestConsumables.Where(T => T.TestID == TestClone.TestID);//TestClone.TestConsumables.AsQueryable();
            }
            else
            {
                items = _context.TestConsumables.Where(o => o.Item != null && o.TestID==TestClone.TestID && o.Item.Name.ToLower().Contains(search)).AsQueryable();
            }


            var model = new GridModelBuilder<TestConsumable>(items, g)
            {
                Key = "TestConsumableID", // needed for api select, update, tree, nesting, EF
                GetItem = () => TestClone.TestConsumables.FirstOrDefault(T => T.TestConsumableID == Convert.ToInt32(g.Key)), // called by the grid.api.update
                Map = MapToGridModel,
            }.Build();

            JsonResult jr = new JsonResult(model);
            return jr;
        }
        public IActionResult OnPostCreate(TestConsumable input)
        {
            if (TestClone == null)
            {
                _context.Tests.Add(Test);
                _context.SaveChangesAsync();
                TestClone = Test;
            }
            if (ModelState.IsValid)
            {
                var item = _context.Items.FirstOrDefault(I => I.ItemID == input.ItemID);
                var test = _context.Tests.FirstOrDefault(I => I.TestID == input.TestID);

                var dinner = new TestConsumable
                {
                    Quantity = input.Quantity,
                    TestID = TestClone.TestID,
                    Item = item,
                    Test = test
                };
                _context.TestConsumables.Add(dinner);
                _context.SaveChanges();

                return new JsonResult(new { Item = MapToGridModel(dinner) });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }

        public IActionResult OnPostEdit(TestConsumable input)
        {
            if (ModelState.IsValid)
            {
                var item = _context.Items.FirstOrDefault(I => I.ItemID == input.ItemID);

                var dinner = _context.TestConsumables.FirstOrDefault(T => T.TestConsumableID == input.TestConsumableID);
                dinner.Quantity = input.Quantity;
                dinner.ItemID = input.ItemID;
                dinner.TestID = input.TestID;

                _context.Attach(dinner).State = EntityState.Modified;

                _context.SaveChangesAsync();

                return new JsonResult(new { });
            }

            return new JsonResult(ModelState.GetErrorsInline());
        }

        public IActionResult OnGetDelete(int id)
        {
            var dinner = TestClone.TestConsumables.FirstOrDefault(T => T.TestID == id);

            return Partial("Delete", new DeleteConfirmInput
            {
                Id = id,
                Type = "consumables",
                Name = dinner.TestConsumableID.ToString()
            });
        }

        public IActionResult OnPostDelete(DeleteConfirmInput input)
        {
            var consumable = TestClone.TestConsumables.FirstOrDefault(T => T.TestConsumableID == input.Id);

            if (consumable != null)
            {
                _context.TestConsumables.Remove(consumable);
                _context.SaveChangesAsync();
            }

            // the PopupForm's success function utils.itemDeleted expects an obj with "Id" property
            return new JsonResult(new { input.Id });
        }
    }
}
