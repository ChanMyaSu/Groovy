using Microsoft.AspNetCore.Identity;

namespace Groovy.Data
{
    public class GroovyUser : IdentityUser
    {
        public string? DisplayName { get; set; }
    }
}
