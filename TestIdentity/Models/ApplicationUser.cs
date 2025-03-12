using Microsoft.AspNetCore.Identity;

namespace TestIdentity.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string ? Adress { get; set; }
    }
}
