using System.Collections.Generic;
using Blazor.Db.Entities;
using Blazor.WebDb;

namespace Blazor.Logic
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