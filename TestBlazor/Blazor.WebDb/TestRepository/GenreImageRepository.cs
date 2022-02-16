using System.Collections.Generic;
using System.Linq;
using Blazor.Db.Entities.TestModel23;

namespace Blazor.WebDb.TestRepository
{
    public class GenreImageRepository : IGenreImageRepository
    {
        readonly List<GenreImage> _genreImage;

        public GenreImageRepository()
        {
            _genreImage = new List<GenreImage>
            {
                new()
                {
                    Id = 1,
                    Name = "RPG"
                },
                new()
                {
                    Id = 2,
                    Name = "Action"
                },
            };
        }

        public List<GenreImage> GetAllGenres()
        {
            return _genreImage;
        }

        public GenreImage GetGenre(int id)
        {
            return _genreImage.FirstOrDefault(g => g.Id == id);
        }

        public bool EditGenre(GenreImage editedGenre)
        {
            var oldGenre = _genreImage.FirstOrDefault(g => g.Id == editedGenre.Id);

            if (oldGenre is not null)
            {
                oldGenre = editedGenre;
                return true;
            }

            return false;
        }
    }
}
