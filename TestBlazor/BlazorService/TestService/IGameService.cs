using System.Collections.Generic;
using Blazor.Db.Entities.Test;

namespace Blazor.Logic.TestService
{
    public interface IGameService
    {
        List<Game> GetAllGames();
    }
}