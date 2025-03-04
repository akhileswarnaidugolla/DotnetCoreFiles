using Microsoft.EntityFrameworkCore;
using OneToOneRelationship.Models;

namespace OneToOneRelationship
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Passport> Passports { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Person>()
        //        .HasOne(p => p.Passport)            // A Person has one Passport
        //        .WithOne(p => p.Person)             // A Passport is associated with one Person
        //        .HasForeignKey<Passport>(p => p.PersonId)  // The foreign key is in the Passport
        //        .OnDelete(DeleteBehavior.Cascade);   // Optional: Cascade delete
        //}

    }
}
