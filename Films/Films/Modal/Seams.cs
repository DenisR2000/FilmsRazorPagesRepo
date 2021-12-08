using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Modal
{
    public class Seams
    {
        public int SeamsId { get; set; }
        public string Time { get; set; }
        public int Prise { get; set; }
        public string Hall { get; set; }
        public int FilmDataId { get; set; }
        public FilmData Films { get; set; }
    }
}
