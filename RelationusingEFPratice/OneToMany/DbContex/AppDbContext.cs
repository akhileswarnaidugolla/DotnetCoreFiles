using Microsoft.EntityFrameworkCore;
using OneToMany.Models;

namespace OneToMany.DbContex
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure one-to-many relationship using Fluent API
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)  // Each Book has one Author
                .WithMany(a => a.Books) // Each Author has many Books
                .HasForeignKey(b => b.AuthorId) // Foreign key in Book
                .OnDelete(DeleteBehavior.Cascade); // Optional: Cascade delete
        }
    }
}
