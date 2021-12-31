using System.ComponentModel.DataAnnotations;

namespace MvcEntity.Web.Models
{
    public class LoginModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указан Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}