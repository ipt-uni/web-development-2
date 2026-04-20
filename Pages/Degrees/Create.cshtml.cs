using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab2.Data;
using lab2.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace lab2.Pages.Degrees
{
    public class CreateModel : PageModel
    {
        private readonly lab2.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CreateModel(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _webHostEnvironment = environment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Degree Degree { get; set; } = default!;

        [BindProperty]
        public IFormFile ImageLogo { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            /* Algorithm to save the file to the server
             * to check if we have a file
             *	if yes, we need to see it that it is an image
             *		if yes, we need to specify the image name and path on where to save.
             *			then define where to save the file
             *			assign the image name to the degree object
             *			save the file to the server
             *	otherwise
             *	send an error message to the user
             *	indicating the file is not an image
             */

            if (ImageLogo == null || ImageLogo.Length == 0)
            {
                Console.WriteLine("Error 1");
                ModelState.AddModelError("ImageLogo", "Please upload an image file");
                return Page();
            }

            if (!(ImageLogo.ContentType == "image/jpeg" || ImageLogo.ContentType == "image/png"))
            {
                Console.WriteLine("Error 2");
                ModelState.AddModelError(
                    "ImageLogo",
                    "Please upload an image file that is either JPEG or PNG"
                );
                return Page();
            }
            string imageName =
                Guid.NewGuid().ToString()
                + Path.GetExtension(ImageLogo.FileName).ToLowerInvariant();
            Degree.Logotype = imageName;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _context.Degrees.Add(Degree);
                await _context.SaveChangesAsync();
                string imagePath = _webHostEnvironment.WebRootPath;
                imagePath = Path.Combine(imagePath, "images");
                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }
                imagePath = Path.Combine(imagePath, imageName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await ImageLogo.CopyToAsync(stream);
                }
                return RedirectToPage("./Index");
            }
            catch (Exception e)
            {
                // throw; // this is only for development mode since it will prince the stacktrace to the window.
                // that is why we don't use it in production mode.

                ModelState.AddModelError(
                    String.Empty,
                    "An error occured while creating the degree. Please try aggain."
                );
                return Page();
            }
        }
    }
}
