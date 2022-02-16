using System.Collections.Generic;
using Blazor.Db.Entities.TestModel23;
using Blazor.WebDb.TestRepository;

namespace Blazor.Logic.TestService
{
    public class GenreImageService : IGenreImageService
    {
        private readonly IGenreImageRepository _repository;

        public GenreImageService(IGenreImageRepository repository)
        {
            _repository = repository;
        }

        public List<GenreImage> GetAllGenres()
        {
            return _repository.GetAllGenres();
        }

        public GenreImage GetGenre(int id)
        {
            return _repository.GetGenre(id);
        }

        public bool EditGenre(GenreImage editedGenre)
        {
            return _repository.EditGenre(editedGenre);
        }
    }
}
