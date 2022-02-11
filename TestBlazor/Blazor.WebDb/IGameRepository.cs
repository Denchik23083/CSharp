using System.Collections.Generic;
using Blazor.Db.Entities;

namespace Blazor.WebDb
{
    public interface IGameRepository
    {
        List<Game> GetAllGames();
    }
}