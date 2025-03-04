using System.ComponentModel.DataAnnotations;

namespace OneToOneRelationship.Models
{
    public class Passport
    {
        [Key]
        int PassportId { get; set; }
        public string PassportNumber { get; set; }=string.Empty;

        // Foreign key to Person (One-to-One)
        public int PersonId { get; set; }

        // Navigation property back to the Person
        public Person? Person { get; set; }
    }
}
