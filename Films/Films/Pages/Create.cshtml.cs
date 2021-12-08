using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Films.Modal;
using FilmsInfo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Films.Pages
{
    public class CreateModel : PageModel
    {
        FilmContext context;
        public CreateModel(FilmContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FilmData Film { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            context.Films.Add(Film);
            context.SaveChanges();

            return RedirectToPage("Admin");
        }
    }
}
