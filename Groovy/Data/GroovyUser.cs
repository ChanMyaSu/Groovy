using Microsoft.AspNetCore.Identity;

namespace Groovy.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class GroovyUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
