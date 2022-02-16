using System.Collections.Generic;
using Blazor.Db.Entities.TestModel23;
using Blazor.WebDb.TestRepository;

namespace Blazor.Logic.TestService
{
    public class GameImageService : IGameImageService
    {
        private readonly IGameImageRepository _repository;

        public GameImageService(IGameImageRepository repository)
        {
            _repository = repository;
        }

        public List<GameImage> GetAllGames()
        {
            return _repository.GetAllGames();
        }
    }
}
