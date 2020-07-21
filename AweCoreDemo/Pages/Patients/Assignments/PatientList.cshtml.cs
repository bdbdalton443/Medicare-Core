using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoHms.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoHms.Pages.Patients.Assignments
{
    public class PatientListModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public PatientListModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Patient> Patient { get; set; }

        public async Task OnGetAsync()
        {
            Patient = await _context.Patients
                .Include(p => p.ArmyStatus)
                .Include(p => p.ArmyUnit)
                .Include(p => p.Family)
                .Include(p => p.Hospital)
                .Include(p => p.NextOfKin)
                .Include(p => p.Organisation)
                .Include(p => p.Rank)
                .ToListAsync();
        }
    }
}