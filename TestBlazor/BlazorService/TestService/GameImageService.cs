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

        public GameImage GetGameById(int id)
        {
            return _repository.GetGameById(id);
        }

        public bool CreateNewGame(GameImage game)
        {
            return _repository.CreateNewGame(game);
        }

        public bool UpdateGame(GameImage game)
        {
            return _repository.UpdateGame(game);
        }

        public bool Remove(GameImage gameToDelete)
        {
            return _repository.Remove(gameToDelete);
        }
    }
}
