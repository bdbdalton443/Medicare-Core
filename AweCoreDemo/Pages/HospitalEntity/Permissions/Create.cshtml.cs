using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoHms.Data;

namespace DemoHms.Pages.HospitalEntity.Permissions
{
    public class CreateModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public CreateModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ActivityID"] = new SelectList(_context.Activity, "ActivityID", "Name");
        ViewData["EmployeeGroupID"] = new SelectList(_context.EmployeeGroups, "EmployeeGroupID", "Name");
            return Page();
        }

        [BindProperty]
        public Permission Permission { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var group = _context.EmployeeGroups.FirstOrDefault(E => E.EmployeeGroupID == Permission.EmployeeGroupID);
            var activity = _context.Activity.FirstOrDefault(E => E.ActivityID == Permission.ActivityID);
            Permission.Name = group.Name + " (" + activity.Name + ")";
            
            _context.Permissions.Add(Permission);

            await _context.SaveChangesAsync();
            Permission permissn = null;
            Activity activity1 = null;
            switch (activity.Name)
            {
                case "Patient Registry":
                case "Doctors Prescriptions":
                case "Patient Receiptions":
                case "Laboratory Tests":
                case "Dispensory Data":
                case "Stock Management":
                    permissn = new Permission();
                    activity1 = _context.Activity.FirstOrDefault(A=>A.Name=="Medical Management");
                    permissn.Name = group.Name + " (" + activity1.Name + ")";
                    permissn.EmployeeGroupID = group.EmployeeGroupID;
                    permissn.ActivityID = activity1.ActivityID;
                    _context.Permissions.Add(permissn);
                    break;
                case "Bill Payments":
                case "Accounts Data":
                    permissn = new Permission();
                    activity1 = _context.Activity.FirstOrDefault(A => A.Name == "Accounts Management");
                    permissn.Name = group.Name + " (" + activity1.Name + ")";
                    permissn.EmployeeGroupID = group.EmployeeGroupID;
                    permissn.ActivityID = activity1.ActivityID;
                    _context.Permissions.Add(permissn);
                    break;
                case "Item Registry":
                case "Purchasing":
                case "Transfers":
                    permissn = new Permission();
                    activity1 = _context.Activity.FirstOrDefault(A => A.Name == "Logistics Management");
                    permissn.Name = group.Name + " (" + activity1.Name + ")";
                    permissn.EmployeeGroupID = group.EmployeeGroupID;
                    permissn.ActivityID = activity1.ActivityID;
                    _context.Permissions.Add(permissn);
                    break;
                case "Employee Data":
                case "Deployment Data":
                    permissn = new Permission();
                    activity1 = _context.Activity.FirstOrDefault(A => A.Name == "Human Resource Management");
                    permissn.Name = group.Name + " (" + activity1.Name + ")";
                    permissn.EmployeeGroupID = group.EmployeeGroupID;
                    permissn.ActivityID = activity1.ActivityID;
                    _context.Permissions.Add(permissn);
                    break;
                case "Organisation Settings":
                case "Human Resource Settings":
                case "Patient Settings":
                case "Permissions Settings":
                case "Logistic Settings":
                case "Examinations Settings":
                    permissn = new Permission();
                    activity1 = _context.Activity.FirstOrDefault(A => A.Name == "Settings");
                    permissn.Name = group.Name + " (" + activity1.Name + ")";
                    permissn.EmployeeGroupID = group.EmployeeGroupID;
                    permissn.ActivityID = activity1.ActivityID;
                    permissn.ActivityID = activity1.ActivityID;
                   
                    break;
                default:
                    break;
            }
            if (permissn != null && _context.Permissions.FirstOrDefault(P => P.Name == permissn.Name) == null)
            {
                _context.Permissions.Add(permissn);
                _context.SaveChanges();
            }
            return RedirectToPage("./Index");
        }
    }
}
