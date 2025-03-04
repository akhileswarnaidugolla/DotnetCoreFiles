using AuthenticationAndAuthorizationUsingJWT.Models;
using AuthenticationAndAuthorizationUsingJWT.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthenticationAndAuthorizationUsingJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<AuthController> _logger;
        private readonly AuthContext _context;
        private readonly AuthService _authService;

        public AuthController(IConfiguration configuration, ILogger<AuthController> logger,
                              AuthContext context,AuthService authService)
        {
            _configuration = configuration;
            _logger = logger;
            _context = context;
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO loginDTO)
        {
            // Validate the user's credentials (for simplicity, hardcoding here)
            if (loginDTO.Username != "Akhileswar" || loginDTO.Password != "Gakhil/04062001")
            {
                return Unauthorized("Invalid credentials");
            }

            var role = "Admin";


            // Generate a JWT token
            var claims = new[]
            {
                        new Claim(ClaimTypes.Name, loginDTO.Username),
                        //new Claim(ClaimTypes.Role, login.Role) // You can add more claims (roles, permissions, etc.)
                        new Claim(ClaimTypes.Role,role)
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


            return Ok(new { Token = tokenString });
        }



        [HttpPost("Register")]

        public IActionResult RegisterUser(Registration register)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                _context.Registrations.Add(register);
                _context.SaveChanges();
                return Ok();

            }

        }



    }
    

}

//[HttpPost("login")]
//public IActionResult Login([FromBody] LoginDTO loginDTO)
//{
//    // Validate the user's credentials (for simplicity, hardcoding here)
//    if (loginDTO.Username != "Akhileswar" || loginDTO.Password != "Gakhil/04062001")
//    {
//        return Unauthorized("Invalid credentials");
//    }

//    var role = "Admin";


//    // Generate a JWT token
//    var claims = new[]
//    {
//                new Claim(ClaimTypes.Name, loginDTO.Username),
//                //new Claim(ClaimTypes.Role, login.Role) // You can add more claims (roles, permissions, etc.)
//                new Claim(ClaimTypes.Role,role)
//            };

//    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("I am working for Mirafra.gvjhbkjnkgvhbkjn"));
//    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
//    var token = new JwtSecurityToken(
//        issuer: "Mirafra",
//        audience: "ClientofMirafra",
//        claims: claims,
//        expires: DateTime.Now.AddHours(1),
//        signingCredentials: creds
//    );

//    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);


//    return Ok(new { Token = tokenString });
//}