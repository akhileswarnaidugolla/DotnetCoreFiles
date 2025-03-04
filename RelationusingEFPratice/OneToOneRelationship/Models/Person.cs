using System.ComponentModel.DataAnnotations;

namespace OneToOneRelationship.Models
{
    public class Person
    {
        [Key] 
        public int PersonId { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation property to Passport (One-to-One)
        public Passport? Passport { get; set; }

    }
}
