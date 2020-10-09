using LexiconMovie.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMovie.Services
{
    public class GenreSelectService : ISelectService
    {
        private readonly LexiconMovieContext db;

        public GenreSelectService(LexiconMovieContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<SelectListItem>> GetGenresAsync()
        {
            return await db.Movie
                        .Select(m => m.Genre)
                        .Distinct()
                        .Select(m => new SelectListItem
                        {
                            Text = m.ToString(),
                            Value = m.ToString()
                        })
                        .ToListAsync();
        }
    }
}
