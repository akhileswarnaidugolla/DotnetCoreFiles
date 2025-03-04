using System.ComponentModel.DataAnnotations;

namespace AuthenticationAndAuthorizationUsingJWT.Models
{
    public class RegistrationDTO
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string Role { get; set; } = string.Empty;
    }
}
