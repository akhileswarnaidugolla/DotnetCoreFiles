using JWTRolebased.Context;
using JWTRolebased.Models;

namespace JWTRolebased.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AuthContext _authContext;
        public AuthRepository(AuthContext authContext)
        {
            _authContext = authContext;
        }
        public bool IsValidLogin(Login login)
        {
            return true;
        }

        public void Register(Register register)
        {
            _authContext.Registers.Add(register);
            _authContext.SaveChanges();
            
        }

        

        

    }
}
