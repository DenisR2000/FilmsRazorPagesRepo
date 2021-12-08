using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Films.Modal;
namespace Films.Pages
{
    public class DeleteModel : PageModel
    {
        FilmContext context;
        [BindProperty]
        public FilmData Film { get; set; }
        public DeleteModel(FilmContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet(int? id)
        {
            Film = context.Films.FirstOrDefault(m => m.FilmDataId == id);

            if (Film == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            context.Films.Remove(context.Films.Find(id));

            context.SaveChanges();
            return RedirectToPage("Admin");
        }
    }
}
