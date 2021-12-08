using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Films.Modal;
using Microsoft.EntityFrameworkCore;

namespace Films.Pages
{
    public class EditModel : PageModel
    {
        FilmContext context;
        public EditModel(FilmContext context)
        {
            this.context = context;
        }
        [BindProperty]
        public FilmData Film { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Film = await context.Films.FirstOrDefaultAsync(m => m.FilmDataId == id);

            if (Film == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var filmToEdit = context.Films.FirstOrDefault(x => x.FilmDataId == x.FilmDataId);
            filmToEdit.img_src = Film.img_src;
            filmToEdit.Name = Film.Name;
            filmToEdit.Produser = Film.Produser;
            filmToEdit.Description = Film.Description;
            filmToEdit.Genre = Film.Genre;
            context.SaveChanges();
            return RedirectToPage("Admin");
        }

    }
}
