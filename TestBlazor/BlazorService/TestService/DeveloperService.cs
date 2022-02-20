using System.Collections.Generic;
using Blazor.Db.Entities.TestModel23;
using Blazor.WebDb.TestRepository;

namespace Blazor.Logic.TestService
{
    public class DeveloperService : IDeveloperService
    {
        private readonly IDeveloperRepository _repository;

        public DeveloperService(IDeveloperRepository repository)
        {
            _repository = repository;
        }

        public List<GameDeveloper> GetAllDevelopers()
        {
            return _repository.GetAllDevelopers();
        }
    }
}
