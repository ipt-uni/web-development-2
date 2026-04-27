using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab2.Data;
using lab2.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace lab2.Pages.Students
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
            Console.WriteLine("OnGet");
            ViewData["DegreeFK"] = new SelectList(
                _context.Degrees.OrderBy(d => d.Name),
                "Id",
                "Name"
            );
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            Console.WriteLine("OnPostAsync");
            if (!ModelState.IsValid)
            {
                Console.WriteLine("OnPostAsync ModelState Invalid");
                ViewData["DegreeFK"] = new SelectList(
                    _context.Degrees.OrderBy(d => d.Name),
                    "Id",
                    "Name"
                );
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
