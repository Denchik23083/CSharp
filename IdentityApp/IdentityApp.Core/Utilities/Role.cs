using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Core.Utilities
{
    public class Role
    {
        public string? UserId { get; set; }

        public string? UserName { get; set; }

        public List<IdentityRole> AllRoles { get; set; }

        public IList<string> UserRoles { get; set; }

        public Role()
        {
            AllRoles = new List<IdentityRole>();
            UserRoles = new List<string>();
        }
    }
}
