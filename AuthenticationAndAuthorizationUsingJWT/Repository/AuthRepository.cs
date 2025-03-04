using AuthenticationAndAuthorizationUsingJWT.Models;

namespace AuthenticationAndAuthorizationUsingJWT.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AuthContext _context;
        public AuthRepository(AuthContext context) 
        {
            _context = context;

        }
        public Login LoginCheck(Login login)
        {
            var a= _context.Registrations.FirstOrDefault(x=>x.Username==login.Username && x.Password ==login.Password);

            if (a == null)
            {
                throw new Exception("No User withthat cred");
            }
            else
            {
                var loginMember = new Login
                {
                    Username = login.Username,
                    Password = login.Password

                };
                _context.Add(loginMember);
                _context.SaveChanges();
                return loginMember;
            }
            


        }

        public void Register(Registration register)
        {
            throw new NotImplementedException();
        }
    }
}
