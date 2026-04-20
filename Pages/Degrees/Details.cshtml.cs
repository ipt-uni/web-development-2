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
    public class DetailsModel : PageModel
    {
        private readonly lab2.Data.ApplicationDbContext _context;

        public DetailsModel(lab2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Degree Degree { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degree = await _context.Degrees.FirstOrDefaultAsync(m => m.Id == id);
            if (degree == null)
            {
                return NotFound();
            }
            else
            {
                Degree = degree;
            }
            return Page();
        }
    }
}
