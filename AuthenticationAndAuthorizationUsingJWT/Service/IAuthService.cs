using AuthenticationAndAuthorizationUsingJWT.Models;

namespace AuthenticationAndAuthorizationUsingJWT.Service
{
    public interface IAuthService
    {
        void Register(RegistrationDTO registerDTO);

        Login LoginCheck(LoginDTO loginDTO);
    }
}
