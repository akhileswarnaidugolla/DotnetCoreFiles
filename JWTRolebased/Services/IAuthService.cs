using JWTRolebased.Models;

namespace JWTRolebased.Services
{
    public interface IAuthService
    {
        string GenerateToken(Register register);

        string CheckLogin(Login login);

        bool Register(Register register);
    }
}
