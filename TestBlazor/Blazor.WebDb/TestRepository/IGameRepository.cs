using System.Collections.Generic;
using Blazor.Db.Entities.TestModel1;

namespace Blazor.WebDb.TestRepository
{
    public interface IGameRepository
    {
        List<Game> GetAllGames();
    }
}