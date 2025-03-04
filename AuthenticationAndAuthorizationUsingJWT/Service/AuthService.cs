using AuthenticationAndAuthorizationUsingJWT.Models;
using AuthenticationAndAuthorizationUsingJWT.Repository;

namespace AuthenticationAndAuthorizationUsingJWT.Service
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }
        public Login LoginCheck(LoginDTO loginDTO)
        {
            var login = new Login
            {
                Username = loginDTO.Username,
                Password = loginDTO.Password
            };

            var a= _authRepository.LoginCheck(login);

            if (a != null)
            {
                return a;
            }
            else
            {
                throw new Exception("Usernot present withthis cred");
            }

            
        }

        public void Register(RegistrationDTO registerDTO)
        {
            throw new NotImplementedException();
        }
    }
}
