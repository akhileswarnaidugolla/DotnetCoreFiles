using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Runtime.CompilerServices;
using System.Text;

namespace JWTRolebased.CustomAuthentication
{
    public static class CustomAuthentication
    {
        public static void CustomAuthenticationAdd(this IServiceCollection services) 
        {
            var key = Encoding.ASCII.GetBytes("I am working for Mirafra.gvjhbkjnkgvhbkjn"); // Use a secure key in a real app
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = "Mirafra",
                        ValidAudience = "ClientofMirafra",
                        IssuerSigningKey = new SymmetricSecurityKey(key)
                    };
                });
        }
    }
}
