using LexiconIMDB.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LexiconIMDB.Services
{
    public interface IGenreSelectListService
    {
        //Task<IEnumerable<SelectListItem>> GetGenresAsync();
        IEnumerable<SelectListItem> GetGenres(IEnumerable<Movie> movies); 
    }
}