using System.Collections.Generic;
using Blazor.Db.Entities.TestModel23;

namespace Blazor.Logic.TestService
{
    public interface IGenreImageService
    {
        List<GenreImage> GetAllGenres();

        GenreImage GetGenre(int id);

        bool EditGenre(GenreImage editedGenre);
    }
}
