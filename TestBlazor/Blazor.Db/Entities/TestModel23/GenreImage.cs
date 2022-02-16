using System.ComponentModel.DataAnnotations;

namespace Blazor.Db.Entities.TestModel23
{
    public class GenreImage
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
