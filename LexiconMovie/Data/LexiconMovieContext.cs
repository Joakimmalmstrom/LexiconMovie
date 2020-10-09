using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LexiconMovie.Models;

namespace LexiconMovie.Data
{
    public class LexiconMovieContext : DbContext
    {
        public LexiconMovieContext (DbContextOptions<LexiconMovieContext> options)
            : base(options)
        {
        }

        public DbSet<LexiconMovie.Models.Movie> Movie { get; set; }
    }
}
