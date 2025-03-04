using JWTRolebased.Context;
using JWTRolebased.Models;
using JWTRolebased.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTRolebased.Services
{
    public class AuthService :IAuthService
    {
        private readonly AuthContext _authContext;
        private readonly IAuthRepository _authRepository;
        public AuthService(AuthContext authContext, IAuthRepository authRepository)
        {
            _authContext = authContext;
            _authRepository = authRepository;

        }
        public string GenerateToken(Register register)
        {
            // Generate a JWT token
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, register.UserName),
                //new Claim(ClaimTypes.Role, login.Role) // You can add more claims (roles, permissions, etc.)
                new Claim(ClaimTypes.Role,register.Role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("I am working for Mirafra.gvjhbkjnkgvhbkjn"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: "Mirafra",
                audience: "ClientofMirafra",
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenString;
        }

        public string CheckLogin(Login login)
        {
            
             var a = _authContext.Registers.FirstOrDefault(x => x.UserName == login.Username && x.Password == login.Password);


            if (a != null)
            {
                string token=GenerateToken(a);
                return token;
            }
            else 
            {
                throw new Exception("User Credentials are incorrect");

            }
            
        }

        public bool Register(Register register)
        {
            if(register != null)
            {
                _authRepository.Register(register);
                return true;
            }

            return false; 
            
        }
    }
}
