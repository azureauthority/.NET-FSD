using Microsoft.AspNetCore.Identity;

namespace WebApplication13.Models
{
    public class ApplicationUser : IdentityUser
    { 
        public string? FullName { get; set; }
    }
}




