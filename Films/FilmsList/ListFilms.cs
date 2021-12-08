using FilmsInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsList
{
    public class ListFilms
    {
        public List<Film> films { get; set; }
        public ListFilms()
        {
            films = new List<Film>()
            {
                new Film {Name = "Малыш на драйве", Genre = "бБевик", Produser = "Уес Болл", img_src = "https://lamafilm.club/wp-content/uploads/2017/08/malysh-na-drajve.jpg"},
                new Film {Name = "Тачки", Genre = "Мульт-фильм", Produser = "Уес Болл"}
            };
        }
    }
}
