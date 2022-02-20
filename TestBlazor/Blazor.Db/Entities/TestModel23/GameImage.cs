using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Db.Entities.TestModel23
{
    public class GameImage
    {
        public int Id { get; set; } = 1;

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(3), MaxLength(500)]
        public string Description { get; set; }

        public bool InSale { get; set; }

        public string GamePlayVideo { get; set; }

        public List<GameGenreImage> GameGenre { get; set; } = new();

        [Required]
        public DateTime? ReleaseDate { get; set; }

        public string Image { get; set; }
    }
}
