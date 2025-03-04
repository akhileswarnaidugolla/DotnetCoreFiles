using JWTRolebased.Context;
using JWTRolebased.Models;
using JWTRolebased.Repositories;
using JWTRolebased.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTRolebased.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ILogger<AuthController> _logger;
        public AuthController(IAuthService authService, ILogger<AuthController> logger)
        {
            _authService = authService;
            _logger = logger;
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] Login login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var token = _authService.CheckLogin(login);
                    return Ok(token);
                    
                }
                else
                {
                    return BadRequest(ModelState);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            

            
        }

        [HttpPost("Register")]
        public IActionResult Register(Register register)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                   bool a= _authService.Register(register);
                    if(a==true)
                    {
                        return Ok("RegisteredSuccessfully");
                    }

                }
                else
                {
                    return BadRequest(ModelState);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
