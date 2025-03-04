using System.ComponentModel.DataAnnotations;

namespace JWTRolebased.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }=string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
