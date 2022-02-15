using System.Collections.Generic;
using Blazor.Db.Entities.TestModel2;

namespace Blazor.Logic.TestService
{
    public interface IGameImageService
    {
        List<GameImage> GetAllGames();
    }
}