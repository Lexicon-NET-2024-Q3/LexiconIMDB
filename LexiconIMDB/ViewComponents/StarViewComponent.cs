using LexiconIMDB.Data;
using LexiconIMDB.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LexiconIMDB.ViewComponents
{

    //[ViewComponent] //Om vi inte sätter ViewComponent i namnet
    public class StarViewComponent : ViewComponent
    {
        //private readonly LexiconIMDBContext _context;

        //public StarViewComponent(LexiconIMDBContext context)
        //{
        //    _context = context; 
        //}

        public IViewComponentResult Invoke(float rating)
        {
            var roundedRating = (int)Math.Round(rating);

            var model = new StarViewModel
            {
                Stars = roundedRating,
                IsHalfStar = roundedRating % 2 == 1
            };

            return View(model); 
        }
    }
}
