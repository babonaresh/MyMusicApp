using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MyMusicApp.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Gig>Gigs { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}