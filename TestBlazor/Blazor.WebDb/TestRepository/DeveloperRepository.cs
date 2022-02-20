using System.Collections.Generic;
using Blazor.Db.Entities.TestModel23;

namespace Blazor.WebDb.TestRepository
{
    public class DeveloperRepository : IDeveloperRepository
    {
        private readonly List<GameDeveloper> _developers;

        public DeveloperRepository()
        {
            _developers = new List<GameDeveloper>
            {
                new()
                {
                    Id = 1,
                    Name = "CD Project Red",
                    StudioDescription = "Established in 2002",
                    Image = "https://en.cdprojektred.com/wp-content/themes/evp-cdpr/img/cdpr-default.jpg",
                },
                new()
                {
                    Id = 2,
                    Name = "CodeMasters",
                    StudioDescription = "Established in 2000",
                    Image = "https://st.overclockers.ru/images/soft/2021/05/19/eacodem.jpg",
                },
            };
        }

        public List<GameDeveloper> GetAllDevelopers()
        {
            return _developers;
        }
    }
}
