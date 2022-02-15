using System.Collections.Generic;
using Blazor.Db.Entities.TestModel1;

namespace Blazor.Logic.TestService
{
    public interface IGameService
    {
        List<Game> GetAllGames();
    }
}