    using System.ComponentModel.DataAnnotations;

    namespace Groovy.Domain
    {
        public class AppUser : BaseDomainModel
        {
            public int UserId { get; set; }
            public string? Username { get; set; }
            public string? Email { get; set; }
            public string? Password { get; set; }

        }
    }
