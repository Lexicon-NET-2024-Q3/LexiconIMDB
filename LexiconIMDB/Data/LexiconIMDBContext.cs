using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LexiconIMDB.Models.Entities;

namespace LexiconIMDB.Data
{
    public class LexiconIMDBContext : DbContext
    {
        public LexiconIMDBContext(DbContextOptions<LexiconIMDBContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(
             new Movie { Id = 1, Title = "Titanic", Genre = Genre.Drama, ReleaseDate = DateTime.Parse("1997-01-16"), Rating = 7.9F },
             new Movie { Id = 2, Title = "Scream", Genre = Genre.Horror, ReleaseDate = DateTime.Parse("1997-08-01"), Rating = 7.4F },
             new Movie { Id = 3, Title = "The Shining", Genre = Genre.Horror, ReleaseDate = DateTime.Parse("1980-09-26"), Rating = 8.4F },
             new Movie { Id = 4, Title = "300", Genre = Genre.Action, ReleaseDate = DateTime.Parse("2007-04-04"), Rating = 7.6F },
             new Movie { Id = 5, Title = "Interstellar", Genre = Genre.Drama, ReleaseDate = DateTime.Parse("2014-11-07"), Rating = 8.7F },
             new Movie { Id = 6, Title = "The Dark Knight", Genre = Genre.Action, ReleaseDate = DateTime.Parse("2008-07-25"), Rating = 9.1F }

                );
        }
    }
}
