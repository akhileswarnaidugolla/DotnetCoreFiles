using JWTRolebased.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTRolebased.Context
{
    public class AuthContext :DbContext
    {
        public AuthContext(DbContextOptions options) : base(options) { }

        public DbSet<Register> Registers { get; set; }
    }
}
