using Microsoft.AspNetCore.Identity;

namespace CafeDevCode.Database.Entities
{
    // Inherit từ class User của AspNetCore, chứa các data cho authentication
    public class User: IdentityUser
    {
        public string? AuthorId { get; set; }
    }
}
