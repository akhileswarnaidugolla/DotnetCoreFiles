using System.ComponentModel.DataAnnotations;

namespace AuthenticationAndAuthorizationUsingJWT.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        
        public string Username { get; set; }=string.Empty;
        public string Password { get; set; }= string.Empty;

        
    }

}
