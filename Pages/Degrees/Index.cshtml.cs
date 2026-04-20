using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab2.Data;
using lab2.Data.Model;

namespace lab2.Pages.Degrees
{
    public class IndexModel : PageModel
    {
        private readonly lab2.Data.ApplicationDbContext _context;

        public IndexModel(lab2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Degree> Degree { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Degree = await _context.Degrees.ToListAsync();
        }
    }
}
