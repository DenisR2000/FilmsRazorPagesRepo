using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Films.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Seans;

namespace Films.Pages
{
    public class todayfilmsModel : PageModel
    {
        FilmContext context;
        public List<Seams> Seanses { get; set; }
        public todayfilmsModel(FilmContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet(int id)
        {

            return Page();
        }

    }
}
