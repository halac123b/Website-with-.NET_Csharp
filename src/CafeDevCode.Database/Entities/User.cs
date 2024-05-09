using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDevCode.Database.Entities
{   
    // Inherit từ class User của NetCore, chứa các data cho authentication
    public class User: IdentityUser
    {
        public string? AuthorId { get; set; }
    }
}
