using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab2.Data;
using lab2.Data.Model;

namespace lab2.Pages.Degrees
{
    public class EditModel : PageModel
    {
        private readonly lab2.Data.ApplicationDbContext _context;

        public EditModel(lab2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
            Degree = degree;
            HttpContext.Session.SetInt32("DegreeId", Degree.Id);
            // if you are using MVC,
            // you  can store also the name of your action
            HttpContext.Session.SetString("ActionName", "Degree/Edit");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var degreeId = HttpContext.Session.GetInt32("DegreeId");
            var actionName = HttpContext.Session.GetString("ActionName");
            if (degreeId == null || actionName == null)
            {
                ModelState.AddModelError(String.Empty, "Session expired. Please refresh the page.");
                return Page();
            }
            if (degreeId != Degree.Id || actionName != "Degree/Edit")
            {
                // it means the User is trying to harm the system by changing data.
                ModelState.AddModelError(String.Empty, "Session expired. Please refresh the page.");
                return RedirectToPage("./Index");
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Degree).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DegreeExists(Degree.Id))
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

        private bool DegreeExists(int id)
        {
            return _context.Degrees.Any(e => e.Id == id);
        }
    }
}
