﻿namespace IdentityApp.Web.Models
{
    public class CreateUserViewModel
    {
        public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
        
        public int Year { get; set; }
    }
}
