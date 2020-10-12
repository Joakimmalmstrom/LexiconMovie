using LexiconMovie.Data;
using LexiconMovie.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMovie.ViewComponents
{
    public class StarViewComponent : ViewComponent
    {
        private readonly LexiconMovieContext db;

        public StarViewComponent(LexiconMovieContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int movieId)
        {
            var movie = await db.Movie.FindAsync(movieId);

            var doubleRating = (int)Math.Round(movie.Rating * 2);

            var model = new StarViewModel
            {
                Stars = doubleRating / 2,
                IsHalfStar = doubleRating % 2 == 1
            };

            return View(model);
        }
    }
}
