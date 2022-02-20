using System.Collections.Generic;
using Blazor.Db.Entities.TestModel23;

namespace Blazor.Logic.TestService
{
    public interface IGameImageService
    {
        List<GameImage> GetAllGames();
        
        GameImage GetGameById(int id);
        
        bool CreateNewGame(GameImage game);

        bool UpdateGame(GameImage game);

        bool Remove(GameImage gameToDelete);
    }
}