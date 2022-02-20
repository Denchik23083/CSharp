using System.Collections.Generic;
using Blazor.Db.Entities.TestModel23;

namespace Blazor.Logic.TestService
{
    public interface IDeveloperService
    {
        List<GameDeveloper> GetAllDevelopers();
    }
}
