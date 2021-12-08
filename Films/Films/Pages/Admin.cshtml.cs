using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Films.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Films.Pages
{
    public class AdminModel : PageModel
    {
        FilmContext contex;
        public List<FilmData> FilmsDb { get; set; }
        public AdminModel(FilmContext contex)
        {
            this.contex = contex;
        }
        public IActionResult OnGet()
        {
            FilmsDb = contex.Films.ToList();
            return Page();
        }
    }
}
