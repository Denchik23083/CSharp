using Microsoft.AspNetCore.Identity;

namespace Identity.Db.Entities
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
