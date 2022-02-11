using System.Collections.Generic;
using Blazor.Db.Entities;

namespace Blazor.Logic
{
    public interface IGameService
    {
        List<Game> GetAllGames();
    }
}