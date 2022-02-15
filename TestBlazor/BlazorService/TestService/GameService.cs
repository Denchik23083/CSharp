using System.Collections.Generic;
using Blazor.Db.Entities.TestModel1;
using Blazor.WebDb.TestRepository;

namespace Blazor.Logic.TestService
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _repository;

        public GameService(IGameRepository repository)
        {
            _repository = repository;
        }

        public List<Game> GetAllGames()
        {
            return _repository.GetAllGames();
        }
    }
}