using System.Collections.Generic;
using Blazor.Db.Entities.TestModel23;

namespace Blazor.WebDb.TestRepository
{
    public interface IGenreImageRepository
    {
        List<GenreImage> GetAllGenres();

        GenreImage GetGenre(int id);

        bool EditGenre(GenreImage editedGenre);
    }
}
