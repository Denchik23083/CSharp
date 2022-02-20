using System.Collections.Generic;
using Blazor.Db.Entities.TestModel23;

namespace Blazor.WebDb.TestRepository
{
    public interface IGameImageRepository
    {
        List<GameImage> GetAllGames();

        GameImage GetGameById(int id);

        bool CreateNewGame(GameImage game);

        bool UpdateGame(GameImage game);

        bool Remove(GameImage gameToDelete);
    }
}
