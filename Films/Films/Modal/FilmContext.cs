using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Modal
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<FilmData> Films { get; set; }
        public DbSet<Seams> Seams { get; set; }
    }
}
