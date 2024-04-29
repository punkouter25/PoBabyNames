using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PoBabyNames.Models;

namespace PoBabyNames.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
