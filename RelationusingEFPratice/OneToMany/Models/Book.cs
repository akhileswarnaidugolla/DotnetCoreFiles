namespace OneToMany.Models
{
        public class Book
        {
            public int BookId { get; set; }
            public string? Title { get; set; }

            // Foreign key to the Author
            public int AuthorId { get; set; }

            // Navigation property to the related Author
            public Author Author { get; set; }
        }
    
}
