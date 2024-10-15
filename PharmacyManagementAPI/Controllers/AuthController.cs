using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PharmacyManagementAPI.Entities;
using PharmacyManagementAPI.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PharmacyManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        //[HttpPost("register")]
        //public IActionResult Register([FromBody] UserDTO userDTO)
        //{
        //    var user = new User
        //    {
        //        UserName = userDTO.UserName,
        //        Email = userDTO.Email,
        //        PasswordHash = userDTO.Password
        //    };

        //    _userService.Register(user);
        //    return Ok(new { message = "User registered successfully" });
        //}

        //[HttpPost("login")]
        //public IActionResult Login([FromBody] LoginDTO loginDTO)
        //{
        //    var user = _userService.Authenticate(loginDTO.Email, loginDTO.Password);
        //    if (user == null)
        //        return Unauthorized(new { message = "Invalid credentials" });

        //    // Generate JWT token...
        //    var token = GenerateJwtToken(user);
        //    return Ok(new { token });
        //}

        //private string GenerateJwtToken(User user)
        //{
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new[] { new Claim("id", user.UserID.ToString()) }),
        //        Expires = DateTime.UtcNow.AddDays(7),
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };
        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    return tokenHandler.WriteToken(token);
        //}
    }
}

