using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AweCoreDemo.Data;
using DemoHms.Data;

namespace AweCoreDemo.Pages.Finance.FinanceSettings.BillItemTypes
{
    public class IndexModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public IndexModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<BillItemType> BillItemType { get;set; }

        public async Task OnGetAsync()
        {
            BillItemType = await _context.BillItemTypes.ToListAsync();
        }
    }
}
