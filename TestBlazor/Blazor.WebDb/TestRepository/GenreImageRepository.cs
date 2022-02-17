using System.Collections.Generic;
using System.Linq;
using Blazor.Db.Entities.TestModel23;

namespace Blazor.WebDb.TestRepository
{
    public class GenreImageRepository : IGenreImageRepository
    {
        public List<GenreImage> GenreImage;

        public GenreImageRepository()
        {
            GenreImage = new List<GenreImage>
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
            return GenreImage;
        }

        public GenreImage GetGenre(int id)
        {
            return GenreImage.FirstOrDefault(g => g.Id == id);
        }

        public bool EditGenre(GenreImage editedGenre)
        {
            var oldGenre = GenreImage.FirstOrDefault(g => g.Id == editedGenre.Id);

            if (oldGenre is not null)
            {
                oldGenre = editedGenre;
                return true;
            }

            return false;
        }
    }
}
