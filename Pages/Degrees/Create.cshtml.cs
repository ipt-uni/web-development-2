using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using lab2.Data;
using lab2.Data.Model;

namespace lab2.Pages.Degrees
{
    public class CreateModel : PageModel
    {
        private readonly lab2.Data.ApplicationDbContext _context;

        public CreateModel(lab2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Degree Degree { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Degrees.Add(Degree);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
