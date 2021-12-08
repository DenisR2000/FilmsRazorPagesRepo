using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Films.Modal;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Films.Pages
{
    public class IndexModel : PageModel
    {
        FilmContext context;
        public List<FilmData> Films { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FilmGenre { get; set; }

        public IndexModel(FilmContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet()
        {
            IQueryable<string> Name = from f in context.Films 
                                      orderby f.Name 
                                      select f.Name;

            var films = from f in context.Films
                        select f;

            IQueryable<string> genreQuery = from f in context.Films
                                            orderby f.Genre
                                            select f.Genre;

            if (!string.IsNullOrEmpty(SearchString))
            {
                films = films.Where(s => s.Name.Contains(SearchString));
                if (films == null)
                {

                }
            }
            if (!string.IsNullOrEmpty(FilmGenre))
            {
                films = films.Where(f => f.Genre == FilmGenre);
            }
            Genres = new SelectList(genreQuery.Distinct().ToList());
            Films = films.ToList();
            return Page();
        }
        public IActionResult OnPost()
        {
            var films = from f in context.Films
                        select f;

            if (!string.IsNullOrEmpty(SearchString))
            {
                films = films.Where(s => s.Name.Contains(SearchString));
            }
            Films = films.ToList();
            return Page();
        }
    }
}
