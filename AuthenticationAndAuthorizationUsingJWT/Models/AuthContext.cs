using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndAuthorizationUsingJWT.Models
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions options) : base(options) { }
        public DbSet<Login> Logins { get; set; }

        public DbSet<Registration> Registrations { get; set; }
    }
}
