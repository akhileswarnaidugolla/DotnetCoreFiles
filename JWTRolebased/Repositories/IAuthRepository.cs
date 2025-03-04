using JWTRolebased.Models;

namespace JWTRolebased.Repositories
{
    public interface IAuthRepository
    {
        bool IsValidLogin(Login login);
        void Register(Register register);
    }
}
