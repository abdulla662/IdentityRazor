using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestIdentity.Models;

namespace TestIdentity.DataAcess
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public DbSet<ApplicationUser> applicationUsers {  get; set; }   

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
  : base(options)
        {
        }
    }
}
