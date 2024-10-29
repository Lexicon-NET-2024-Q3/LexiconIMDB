using LexiconIMDB.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LexiconIMDB.Services
{
    public class GenreSelectListService : IGenreSelectListService
    {
        private readonly LexiconIMDBContext _context;

        public GenreSelectListService(LexiconIMDBContext contex)
        {
            _context = contex;
        }
        public async Task<IEnumerable<SelectListItem>> GetGenresAsync()
        {
            return await _context.Movies.Select(m => m.Genre)
                .Distinct()
                .Select(g => new SelectListItem
                {
                    Text = g.ToString(),
                    Value = g.ToString()
                }).ToListAsync();
        }
    }
}
