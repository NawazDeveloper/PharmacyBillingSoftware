using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PharmacyManagementAPI.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

 

namespace PharmacyManagementAPI.Middleware
    {
        public class JwtMiddleware
        {
            private readonly RequestDelegate _next;
            private readonly string _secretKey;

            //public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
            //{
            //    _next = next;
            //    _secretKey = appSettings.Value.Secret;
            //}

            //public async Task Invoke(HttpContext context, IUserService userService)
            //{
            //    var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            //    if (token != null)
            //        AttachUserToContext(context, userService, token);

            //    await _next(context);
            //}

            //private void AttachUserToContext(HttpContext context, IUserService userService, string token)
            //{
            //    try
            //    {
            //        var tokenHandler = new JwtSecurityTokenHandler();
            //        var key = Encoding.ASCII.GetBytes(_secretKey);
            //        tokenHandler.ValidateToken(token, new TokenValidationParameters
            //        {
            //            ValidateIssuerSigningKey = true,
            //            IssuerSigningKey = new SymmetricSecurityKey(key),
            //            ValidateIssuer = false,
            //            ValidateAudience = false,
            //            ClockSkew = TimeSpan.Zero
            //        }, out SecurityToken validatedToken);

            //        var jwtToken = (JwtSecurityToken)validatedToken;
            //        var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

            //        context.Items["User"] = userService.GetById(userId);
            //    }
            //    catch
            //    {
            //        // Do nothing if JWT validation fails
            //    }
            //}
        }
    }



