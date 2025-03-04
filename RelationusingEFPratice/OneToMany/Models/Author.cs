namespace OneToMany.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? Name { get; set; } 

        // Navigation property for related books
        public ICollection<Book> Books { get; set; }
    }

}
