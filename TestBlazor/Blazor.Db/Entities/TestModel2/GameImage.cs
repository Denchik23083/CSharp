using System;

namespace Blazor.Db.Entities.TestModel2
{
    public class GameImage
    {
        public int Id { get; set; } = 1;

        public string Name { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Image { get; set; }
    }
}
