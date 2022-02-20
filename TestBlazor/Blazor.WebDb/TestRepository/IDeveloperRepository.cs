using System.Collections.Generic;
using Blazor.Db.Entities.TestModel23;

namespace Blazor.WebDb.TestRepository
{
    public interface IDeveloperRepository
    {
        List<GameDeveloper> GetAllDevelopers();
    }
}
