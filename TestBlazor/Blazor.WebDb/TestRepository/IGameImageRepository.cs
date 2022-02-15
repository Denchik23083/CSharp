using System.Collections.Generic;
using Blazor.Db.Entities.TestModel2;

namespace Blazor.WebDb.TestRepository
{
    public interface IGameImageRepository
    {
        List<GameImage> GetAllGames();
    }
}
