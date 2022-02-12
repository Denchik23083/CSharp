using System.Collections.Generic;
using Blazor.Db.Entities.Test;

namespace Blazor.WebDb.TestRepository
{
    public interface IGameRepository
    {
        List<Game> GetAllGames();
    }
}