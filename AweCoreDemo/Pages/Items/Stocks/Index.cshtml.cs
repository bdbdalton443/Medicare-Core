﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoHms.Data;
using AweCoreDemo.Data;

namespace AweCoreDemo.Pages.Items.Stocks
{
    public class IndexModel : PageModel
    {
        private readonly DemoHms.Data.ApplicationDbContext _context;

        public IndexModel(DemoHms.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Stok> Stock { get;set; }

        public async Task OnGetAsync()
        {
            Stock = await _context.Stoks
                .Include(s => s.Department)
                .Include(s => s.Item).ToListAsync();
        }
    }
}