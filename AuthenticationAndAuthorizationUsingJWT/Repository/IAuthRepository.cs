using AuthenticationAndAuthorizationUsingJWT.Models;

namespace AuthenticationAndAuthorizationUsingJWT.Repository
{
    public interface IAuthRepository
    {
        void Register(Registration register);

        Login LoginCheck(Login login);

      
    }
}
