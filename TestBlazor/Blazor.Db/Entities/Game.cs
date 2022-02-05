using System;

namespace Blazor.Db.Entities
{
    public class Game
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
