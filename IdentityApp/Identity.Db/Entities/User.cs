using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Db.Entities
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
